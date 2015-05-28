// File:    Task.cs
// Author:  Administrator
// Created: 2015��5��19�� 22:15:45
// Purpose: Definition of Class Task

using System;
using ServiceStack.DataAnnotations;

/// �����
public class Task
{
   ///<summary>
   ///����Id
   ///</summary>
    [AutoIncrement]
   public int taskId {get;set;}
   ///<summary>
   ///��������
   ///</summary>
   public string taskName {get;set;}
   ///<summary>
   ///��������
   ///</summary>
   public int processTypeId {get;set;}
   ///<summary>
   ///������־Id
   ///</summary>
   public int processLogId {get;set;}
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
   ///��ǰ����
   ///</summary>
   public int currentSegment {get;set;}

}