// File:    DocInfo.cs
// Author:  rambo
// Created: 2015��5��23�� 15:29:19
// Purpose: Definition of Class DocInfo

using System;

using ServiceStack.DataAnnotations;
/// ������Ϣ��
public class DocInfo
{
   ///<summary>
   ///���ϱ���
   ///</summary>
    [AutoIncrement]
    public long id {get;set;}
   ///<summary>
   ///��������
   ///</summary>
    public string docName {get;set;}
   ///<summary>
   ///��������
   ///</summary>
    public string docType {get;set;}
   ///<summary>
   ///����
   ///</summary>
    public string author {get;set;}
   ///<summary>
   ///������
   ///</summary>
    public string publisher {get;set;}
   ///<summary>
   ///�ܼ�
   ///</summary>
    public string miLevel {get;set;}
   ///<summary>
   ///����Ȩ��
   ///</summary>
    public int readLevel {get;set;}
   ///<summary>
   ///��Դ
   ///</summary>
    public string source {get;set;}
   ///<summary>
   ///�ؼ���
   ///</summary>
    public string keyWord {get;set;}
   ///<summary>
   ///���ʱ��
   ///</summary>
    public DateTime time {get;set;}
   ///<summary>
   ///���ݼ��
   ///</summary>
    public string content {get;set;}
   ///<summary>
   ///�ļ�λ��
   ///</summary>
    public string filePath {get;set;}
   ///<summary>
   ///ɾ����ʾ
   ///</summary>
    public byte deleteFlag {get;set;}

}