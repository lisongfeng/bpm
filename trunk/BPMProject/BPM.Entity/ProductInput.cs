// File:    ProductInput.cs
// Author:  Administrator
// Created: 2015��5��27�� 9:01:08
// Purpose: Definition of Class ProductInput

using System;
using ServiceStack.DataAnnotations;
/// �ʲ�����
public class ProductInput
{
    ///<summary>
   ///Id
   ///</summary>
    [AutoIncrement]
   public long id {get;set;}
    ///<summary>
   ///�ʲ�����
   ///</summary>
   public long productId {get;set;}
    ///<summary>
   ///ʱ��
   ///</summary>
   public DateTime time {get;set;}
    ///<summary>
   ///����
   ///</summary>
   public int quantity {get;set;}
    ///<summary>
   ///������Id
   ///</summary>
   public long userId {get;set;}
    ///<summary>
   ///��Դ
   ///</summary>
   public long source {get;set;}
    ///<summary>
   ///��׼��Id
   ///</summary>
   public long approveId {get;set;}
    ///<summary>
   ///���������
   ///</summary>
   public long relativeTask {get;set;}
    ///<summary>
   ///�ⷿ���
   ///</summary>
   public string storageNum {get;set;}
    ///<summary>
   ///���ܺ�
   ///</summary>
   public string shelf {get;set;}
    ///<summary>
   ///������
   ///</summary>
   public decimal shelfLife {get;set;}

}