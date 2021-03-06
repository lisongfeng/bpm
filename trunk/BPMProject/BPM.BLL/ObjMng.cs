﻿using System.Collections.Generic;
using BPM.Entity;
using ServiceStack.OrmLite;
using BPM.ORMLite;
using BPM.Entity.DTO;
using BPM.Entity.Paged;
namespace BPM.BLL
{
    public class ObjMng
    {
        /// <summary>
        /// 获取所有品名
        /// </summary>
        /// <returns></returns>
        public static PagedList<Product> GetAllPingMing(PageDto dto)
        {
            var express = ORMLite.Utity.Connection.From<Product>();
            int skips = (dto.PageIndex - 1) * dto.PageSize;
            express.Limit(skip: skips, rows: dto.PageSize);
            long allCount = Utity.Connection.Count<Product>(express);
            var list = Utity.Connection.Select<Product>(express);
            var pagedList = new PagedList<Product>(list, dto.PageIndex, dto.PageSize, allCount);

            return pagedList;
        }
        /// <summary>
        /// 获取命名目录
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static List<Product> GetPingMingInfo(string code)
        {
            List<KeyValuePair<int, int>> kpValues = new List<KeyValuePair<int, int>>();
            kpValues.Add(new KeyValuePair<int, int>(0, 2));
            kpValues.Add(new KeyValuePair<int, int>(2, 5));
            kpValues.Add(new KeyValuePair<int, int>(5, 12));
            var sqlexpression = Utity.Connection.From<Product>();

            //判断code的长度
            //0,那么返回第一级目录
            //2位，那么是第一级目录
            //5位，那么是二级目录
            //12位，那么是品名
            //var currentkey = kpValues.Find(s => s.Key == code.Length);
            //sqlexpression.Where("len(productid)={0} and productid/", currentkey.Value);
            switch (code.Length)
            {
                case 0:
                    sqlexpression.Where("len(productid)=2 ");
                    break;
                case 2:
                    sqlexpression.Where("len(productid)=5 and productid/1000={0}", int.Parse(code));
                    break;
                case 5:
                    sqlexpression.Where("len(productid)=12 and productid/10000000={0}", int.Parse(code));
                    break;
            }

            string strSql = sqlexpression.SelectInto<Product>();
            return Utity.Connection.Select<Product>(sqlexpression);
        }
        #region 出库
        /// <summary>
        /// 输入资产内码，返回资产信息和剩余数量
        /// </summary>
        /// <param name="productCode">资产内码</param>
        /// <returns>资产数量实体</returns>
        public static ProductStatiscDto GetProductStatisc(string productCode)
        {
            string strsql=@"SELECT a.ProductId,a.ProductNum,a.ProductName,a.ProductFlag,a.FactoryId,a.DealerId,a.Model,a.Standard,a.Price,a.QuantityUnit,a.HasDelete,a.incount-a.outcount AS stacks from
(SELECT p.ProductId,p.ProductNum,p.ProductName,p.ProductFlag,p.FactoryId,p.DealerId,p.Model,p.Standard,p.Price,p.QuantityUnit,p.HasDelete,SUM(input.Quantity) incount,SUM(outp.Quantity) AS outcount FROM dbo.Product p JOIN dbo.ProductInput input ON p.ProductId=input.ProductId
JOIN dbo.ProductLog  outp ON input.Id=outp.ProductInputId
WHERE p.productid={0}
GROUP BY p.ProductId,p.ProductNum,p.ProductName,p.ProductFlag,p.FactoryId,p.DealerId,p.Model,p.Standard,p.Price,p.QuantityUnit,p.HasDelete) a";
            string strFinalSql = string.Format(strsql, productCode);
            var dto=Utity.Connection.Single<ProductStatiscDto>(strFinalSql);
            return dto;
        }
        /// <summary>
        /// 保存出库信息
        /// </summary>
        /// <param name="productLog"></param>
        /// <returns>返回出库的id号</returns>
        public static long SaveProductLog(ProductLog productLog)
        {
            productLog.time = System.DateTime.Now;
            long lResult = Utity.Connection.Insert<ProductLog>(productLog, selectIdentity: true);
            return lResult;
        }
        #endregion
        #region 入库

        /// <summary>
        /// 入库信息
        /// </summary>
        /// <param name="newProductInput">新的资产入库</param>
        /// <returns>大于0为成功，0为失败</returns>
        public static long SubmitLibrary(ProductInput newProductInput)
        {
            int iResult = 0;
            long lResult = Utity.Connection.Insert<ProductInput>(newProductInput,selectIdentity:true);
            iResult = (int)lResult;
            return iResult;
        }
        #endregion
        /// <summary>
        /// 资产查询
        /// </summary>
        /// <param name="productSearch"></param>
        /// <returns></returns>
        public static List<ProductStatiscDto> SearchProduct(ProductSearchDto productSearch)
        {
            if (productSearch == null) return null;
            string strSql = @"select a.productid,a.productnum,a.productname,a.productflag,a.factoryid,a.dealerid,a.model,a.standard,a.price,a.quantityunit,sum(dd) as stacks
 from (
 select p.*,
 case when l.inout=1 then p.Price*l.Quantity else -1*p.Price*l.Quantity end as dd  
 from Product p join ProductLog l on p.ProductId=l.ProductId
 JOIN Provider pv ON p.FactoryId = pv.CatalogId
                                        AND pv.CatalogKey = '工厂'{0}
 ) a
 group by a.productid,a.productnum,a.productname,a.productflag,a.factoryid,a.dealerid,a.model,a.standard,a.price,a.quantityunit";

            string strFormat = "";
            string strAnd = "";
            string strLikeFormat = " {0} like '{1}%' ";
            if (productSearch.productId > 0) strAnd += "p.productid=" + productSearch.productId.ToString() + " and ";
            if (!string.IsNullOrEmpty(productSearch.productName)) strAnd += string.Format(strLikeFormat, "p.productName", productSearch.productName) + " and ";
            if (!string.IsNullOrEmpty(productSearch.factoryName)) strAnd += string.Format(strLikeFormat, "pv.CatalogName", productSearch.factoryName) + " and ";
            if (!string.IsNullOrEmpty(productSearch.model)) strAnd += string.Format(strLikeFormat, "p.model", productSearch.model) + " and ";
            if (!string.IsNullOrEmpty(productSearch.standard)) strAnd += string.Format(strLikeFormat, "p.standard", productSearch.standard) + " and ";
            strAnd = strAnd.Remove(strAnd.Length - 5, 5);
            if (!string.IsNullOrEmpty(strAnd))
            {
                strFormat = " where " + strAnd;
            }
            string strSqlFormat = string.Format(strSql, strFormat);
            return Utity.Connection.Select<ProductStatiscDto>(strSqlFormat);

        }
        /// <summary>
        /// 资产统计
        /// </summary>
        /// <param name="?"></param>
        /// <returns></returns>
        public static string StaticsProduct(ProductStatiscDto productStatiscDto)
        {
            return @"{code:1,message:’’,result:{
RecordsCounts:1000,currentRows:10,data:
[{productId:111104000001,productNum:’as001dssdf’,AllInput:300,AllOutput:200,Stocks:1000}]}}";
        }
        #region 品名表的增删改查
        /// <summary>
        /// 新增品名
        /// </summary>
        /// <param name="addProductDto"></param>
        /// <returns></returns>
        public static long AddProduct(Product addProductDto)
        {
            long lresult = Utity.Connection.Insert<Product>(addProductDto);
            return lresult;
        }
        /// <summary>
        /// 删除品名
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public static int DeleteProduct(Product product)
        {
            int pLength = product.productId.ToString().Length;
            if (pLength== 12)
            {
            product.hasDelete = 2;
            return UpdateProduct(product);
            }
            else
            {
                Utity.Connection.Update<Product>(new Product(){hasDelete = 2},p=>p.productId.)
            }
            else if()
        }
        /// <summary>
        /// 更新品名表
        /// </summary>
        /// <param name="?"></param>
        /// <returns></returns>
        public static int UpdateProduct(Product product)
        {
            var lresult = Utity.Connection.Update<Product>();
            return lresult;
        }
        #endregion
        /// <summary>
        /// 获取类似xx%的品名列表De
        /// </summary>
        /// <param name="key">资产关键字</param>
        /// <returns>资产列表</returns>
        public static List<Product> GetProductList(string key)
        {
            List<Product> list = new List<Product>();
            var expression = Utity.Connection.From<Product>();
            expression.Where<Product>(s => s.productName.StartsWith(key));
            //执行查询，返回实体列表
            list = Utity.Connection.Select<Product>(expression);
            return list;
        }
        /// <summary>
        /// 获取类似xx%的厂家列表
        /// </summary>
        /// <param name="providerName">厂家关键字</param>
        /// <returns>厂家列表</returns>
        public static List<Provider> GetProviderList(string catalogName)
        {
            List<Provider> list = new List<Provider>();
            var expression = Utity.Connection.From<Provider>();
            expression.Where<Provider>(s => s.catalogName.StartsWith(catalogName));
            expression.Where<Provider>(s => s.catalogKey == "厂家");
            //执行查询，返回实体列表
            list = Utity.Connection.Select<Provider>(expression);
            return list;
        }
        //获取型号

        //生成二维码

        /// <summary>
        /// 获取资产树
        /// </summary>
        /// <returns></returns>
        public static List<TreeDto> GetPinMingTree()
        {
            var express = ORMLite.Utity.Connection.From<Product>();
            long allCount = Utity.Connection.Count<Product>(express);
            var list = Utity.Connection.Select<Product>(express);
            var treeDtoList = new List<TreeDto>();
            //取第一层
            foreach (var product in list)
            {
                if (product.productId <= 99 && product.productId >= 10)
                {
                    treeDtoList.Add(new TreeDto() { id = product.productId.ToString(), text = product.productName, children = new List<TreeDto>(), Node = product });
                }
            }
            //取第二层，依次加入第一层
            foreach (var product in list)
            {
                if (product.productId >= 10000 && product.productId <= 99999)
                {
                    int parant = (int)product.productId / 1000;
                    var current = new TreeDto()
                        {
                            id = product.productId.ToString(),
                            text = product.productName,
                            children = new List<TreeDto>(),
                            Node = product
                        };

                    var parentNode = treeDtoList.Find(s => s.id == parant.ToString());
                    if (parentNode != null)
                    {
                        parentNode.children.Add(current);
                    }
                }
            }
            //取第三层，加入第二层
            foreach (var product in list)
            {
                if (product.productId >= 100000000000 && product.productId <= 999999999999)
                {
                    int parant = (int)(product.productId / 10000000);
                    int grandpa = (int)(parant / 1000);
                    var current = new TreeDto()
                        {
                            id = product.productId.ToString(),
                            text = product.productName,
                            children = new List<TreeDto>(),
                            Node = product
                        };
                    var grandpaNode = treeDtoList.Find(s => s.id == grandpa.ToString());
                    if (grandpaNode != null)
                    {
                        var parentNode = grandpaNode.children.Find((s => s.id == parant.ToString()));
                        if (parentNode != null)
                        {
                            parentNode.children.Add(current);
                        }
                    }
                }
            }
            return treeDtoList;
        }
    }
}
