// File:    Product.cs
// Author:  Administrator
// Created: 2015��5��19�� 22:15:45
// Purpose: Definition of Class Product

using System;

/// �ʲ�Ʒ��
public class Product
{
   ///<summary>
   ///�ʲ�����
   ///</summary>
   public long productId {get;set;}
   ///<summary>
   ///�ʲ�����
   ///</summary>
   public string productNum {get;set;}
   ///<summary>
   ///�ʲ�����
   ///</summary>
   public string productName {get;set;}
   ///<summary>
   ///�ʲ�����(1ΪĿ¼,2Ϊ�ʲ�)
   ///</summary>
   public byte productFlag {get;set;}
   ///<summary>
   ///��������Id
   ///</summary>
   public long factoryId {get;set;}
   ///<summary>
   ///������Id
   ///</summary>
   public long dealerId {get;set;}
   ///<summary>
   ///�ͺ�
   ///</summary>
   public string model {get;set;}
   ///<summary>
   ///���
   ///</summary>
   public string standard {get;set;}
   ///<summary>
   ///����
   ///</summary>
   public double price {get;set;}
   ///<summary>
   ///������λ
   ///</summary>
   public string quantityUnit {get;set;}
   ///<summary>
   ///ɾ����ʾ
   ///</summary>
   public byte hasDelete {get;set;}

}