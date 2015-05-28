SELECT  a.productid ,
        a.productnum ,
        a.productname ,
        a.productflag ,
        a.factoryid ,
        a.dealerid ,
        a.model ,
        a.standard ,
        a.price ,
        a.quantityunit ,
        SUM(dd) AS stacks
FROM    ( SELECT    p.* ,
                    CASE WHEN l.inout = 1 THEN p.Price * l.Quantity
                         ELSE -1 * p.Price * l.Quantity
                    END AS dd
          FROM      Product p
                    JOIN ProductLog l ON p.ProductId = l.ProductId
                    JOIN Provider pv ON p.FactoryId = pv.CatalogId
                                        AND pv.CatalogKey = '����'
        ) a
GROUP BY a.productid ,
        a.productnum ,
        a.productname ,
        a.productflag ,
        a.factoryid ,
        a.dealerid ,
        a.model ,
        a.standard ,
        a.price ,
        a.quantityunit

INSERT  INTO Provider
VALUES  ( 123, '���������쳧', '����', '', '' );
INSERT  INTO Provider
VALUES  ( 124, '�������쳧', '����', '', '' );
INSERT  INTO Provider
VALUES  ( 125, '������������', '������', '', '' );
INSERT  INTO Provider
VALUES  ( 126, '����������', '������', '', '' );