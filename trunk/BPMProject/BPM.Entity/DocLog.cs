// File:    DocLog.cs
// Author:  rambo
// Created: 2015��5��23�� 15:29:19
// Purpose: Definition of Class DocLog

using System;

using ServiceStack.DataAnnotations;
/// ���ϱ䶯��Ϣ��
public class DocLog
{
   ///<summary>
   ///��־Id
   ///</summary>
    [AutoIncrement]
    public long id {get;set;}
   ///<summary>
   ///���ϱ���
   ///</summary>
    public long docId {get;set;}
   ///<summary>
   ///������
   ///</summary>
    public string borrower {get;set;}
   ///<summary>
   ///ʱ��
   ///</summary>
    public DateTime time {get;set;}
   ///<summary>
   ///��¼����
   ///</summary>
    public string recordType {get;set;}
   ///<summary>
   ///��ע
   ///</summary>
    public string remarks {get;set;}
   ///<summary>
   ///��������
   ///</summary>
    public int borrowDays {get;set;}
   ///<summary>
   ///ʵ�ʹ黹ʱ��
   ///</summary>
    public DateTime returnTime {get;set;}

}