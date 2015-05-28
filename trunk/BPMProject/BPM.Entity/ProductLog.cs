// File:    ProductLog.cs
// Author:  Administrator
// Created: 2015��5��19�� 22:15:45
// Purpose: Definition of Class ProductLog

using System;
using ServiceStack.DataAnnotations;
/// �ʲ�����
public class ProductLog
{
   ///<summary>
   ///Id
   ///</summary>
    [AutoIncrement]
   public long id {get;set;}
   ///<summary>
   ///���Id
   ///</summary>
   public long productInputId {get;set;}
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
   public string source {get;set;}
   ///<summary>
   ///��׼��Id
   ///</summary>
   public long approveId {get;set;}
   ///<summary>
   ///���������
   ///</summary>
   public long relativeTask {get;set;}

}