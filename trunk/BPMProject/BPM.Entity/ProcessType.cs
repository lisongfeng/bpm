// File:    ProcessType.cs
// Author:  Administrator
// Created: 2015��5��19�� 22:15:45
// Purpose: Definition of Class ProcessType

using System;

/// �������ͱ�
public class ProcessType
{
   ///<summary>
   ///��������Id
   ///</summary>
   public int processTypeId {get;set;}
   ///<summary>
   ///������������
   ///</summary>
   public string processTypeName {get;set;}
   ///<summary>
   ///������������
   ///</summary>
   public string processTypeTitle {get;set;}
   ///<summary>
   ///�׻�
   ///</summary>
   public int firstSegment {get;set;}
   ///<summary>
   ///ĩ��
   ///</summary>
   public int endSegment {get;set;}
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
   ///����������Id
   ///</summary>
   public int parentId {get;set;}

}