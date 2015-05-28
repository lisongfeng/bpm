// File:    ProcessLog.cs
// Author:  Administrator
// Created: 2015��5��19�� 22:15:45
// Purpose: Definition of Class ProcessLog

using System;

using ServiceStack.DataAnnotations;
/// ������־��
public class ProcessLog
{
   ///<summary>
   ///������־Id
   ///</summary>
[AutoIncrement]    
   public int processLogId {get;set;}
   ///<summary>
   ///����Id
   ///</summary>
   public int segmentId {get;set;}
   ///<summary>
   ///������
   ///</summary>
   public string tableName {get;set;}
   ///<summary>
   ///������
   ///</summary>
   public string createUser {get;set;}
   ///<summary>
   ///����ʱ��
   ///</summary>
   public DateTime createTime {get;set;}
   ///<summary>
   ///����ʱ��
   ///</summary>
   public DateTime updateTime {get;set;}
   ///<summary>
   ///�ͻ�ip
   ///</summary>
   public string ipaddress {get;set;}

}