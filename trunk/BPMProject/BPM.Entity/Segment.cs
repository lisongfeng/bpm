// File:    Segment.cs
// Author:  Administrator
// Created: 2015��5��19�� 22:15:45
// Purpose: Definition of Class Segment

using System;
using ServiceStack.DataAnnotations;
/// ����
public class Segment
{
   ///<summary>
   ///����ID
   ///</summary>
    [AutoIncrement]
   public int segmentId {get;set;}
   ///<summary>
   ///������
   ///</summary>
   public string segmentName {get;set;}
   ///<summary>
   ///��������
   ///</summary>
   public string segmentTitle {get;set;}
   ///<summary>
   ///������
   ///</summary>
   public string includeTable {get;set;}
   ///<summary>
   ///�����ֶ�
   ///</summary>
   public string includeParam {get;set;}
   ///<summary>
   ///������
   ///</summary>
   public string blameName {get;set;}
   ///<summary>
   ///ǰһ����
   ///</summary>
   public int preSegment {get;set;}
   ///<summary>
   ///��ת���ʽ
   ///</summary>
   public string actionExpression {get;set;}
   ///<summary>
   ///����ʱ��
   ///</summary>
   public DateTime createTime {get;set;}
   ///<summary>
   ///����ʱ��
   ///</summary>
   public DateTime updateTime {get;set;}

}