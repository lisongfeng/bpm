// File:    Provider.cs
// Author:  Administrator
// Created: 2015��5��19�� 22:15:45
// Purpose: Definition of Class Provider

using System;
using ServiceStack.DataAnnotations;

/// ���
public class Provider
{
   ///<summary>
   ///���id
   ///</summary>
    [AutoIncrement]
   public long catalogId {get;set;}
   ///<summary>
   ///�������
   ///</summary>
   public string catalogName {get;set;}
   ///<summary>
   ///�ؼ���
   ///</summary>
   public string catalogKey {get;set;}
   ///<summary>
   ///��ע1
   ///</summary>
   public string remark1 {get;set;}
   ///<summary>
   ///��ע2
   ///</summary>
   public string remark2 {get;set;}

}