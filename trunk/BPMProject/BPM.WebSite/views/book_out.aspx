﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="book_out.aspx.cs" Inherits="views_book_out" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head>
    <title>图书借阅流程</title>
    <link rel="stylesheet" type="text/css" href="../css/skin.css" />
    <link rel="stylesheet" type="text/css" href="../scripts/widget/jstree/themes/default/style.min.css" />
    <script type="text/javascript" src="../scripts/widget/jstree/jquery-1.11.2.min.js"></script>
    <script type="text/javascript" src="../scripts/widget/jstree/jstree.js"></script>
    <script type="text/javascript" src="../scripts/widget/qrcode/jquery.qrcode.js"></script>
    <script type="text/javascript" src="../scripts/widget/qrcode/qrcode.js"></script>
    <script type="text/javascript" src="../scripts/book_out.js"></script>
</head>
<body>
<form id="form1" runat="server">
    <table cellpadding="0" cellspacing="0" style="width:830px" border="0">
        <tr>
            <td  align="center" colspan ="2" class="Tbl_TD_Title">图书借阅流程</td>
        </tr>
        <tr>
            <td  align="left" style="width:100px;height:24px">借阅日期：</td>
            <td  align="left" style="width:730px;height:24px">
                <span id="tb_bookmng_time" class="Tbl_TD_TextBox"></span></td>
        </tr>
    </table>
    <table cellpadding="0" cellspacing="0" class="Tbl_Info">
        <tr>
            <td  align="left" class="Tbl_TD_Label">二&nbsp; 维&nbsp; 码：</td>
            <td  align="left" colspan="3" class="Tbl_TD_Txt">
                <input id="btn_bookmng_scan" type="button" style=" width:70px;" value="扫描" />
        </tr>
        <tr>
            <td  align="left" colspan="4" style="width:300px;height:200px">
                <div id="div_bookmng_qrcode" class="Div_qrcode"></div>
            </td>
        </tr>
        <tr>
            <td  align="left" class="Tbl_TD_Label">图书名称：</td>
            <td  align="left" class="Tbl_TD_Txt"><input id="tb_bookmng_name" class="Tbl_TD_TextBox" type="text" maxlength="48"/>
            </td>
            <td  align="left" class="Tbl_TD_Label">文档类型：</td>
            <td  align="left" class="Tbl_TD_Txt"><span id="tb_bookmng_type" class="Tbl_TD_TextBox"></span></td>
        </tr>
        <tr>
            <td  align="left" class="Tbl_TD_Label">作者：</td>
            <td  align="left" class="Tbl_TD_Txt"><span id="tb_bookmng_author" class="Tbl_TD_TextBox"></span></td>
            <td  align="left" class="Tbl_TD_Label">出版社：</td>
            <td  align="left" class="Tbl_TD_Txt"><span id="tb_bookmng_publisher" class="Tbl_TD_TextBox"></span></td>
        </tr>
        <tr>
            <td  align="left" class="Tbl_TD_Label">来源：</td>
            <td  align="left" class="Tbl_TD_Txt"><span id="tb_bookmng_source" class="Tbl_TD_TextBox"></span></td>
            <td  align="left" class="Tbl_TD_Label">借阅范围：</td>
            <td  align="left" class="Tbl_TD_Txt"><span id="tb_bookmng_readlevel" class="Tbl_TD_TextBox"></span></td>
        </tr>
        <tr>
            <td  align="left" class="Tbl_TD_Label">单价：</td>
            <td  align="left" class="Tbl_TD_Txt"><span id="tb_bookmng_price" class="Tbl_TD_TextBox"></span></td>
            <td  align="left" class="Tbl_TD_Label">存放位置：</td>
            <td  align="left" class="Tbl_TD_Txt"><span id="tb_bookmng_store" class="Tbl_TD_TextBox"></span></td>
        </tr>
        <tr>
            <td  align="left" class="Tbl_TD_Label">借阅人：</td>
            <td  align="left" class="Tbl_TD_Txt"><input id="tb_bookmng_borrow" class="Tbl_TD_TextBox" type="text" maxlength="48"/></td>
            <td  align="left" class="Tbl_TD_Label">归还时间：</td>
            <td  align="left" class="Tbl_TD_Txt"><input id="tb_bookmng_return_time" class="Tbl_TD_TextBox" type="text" maxlength="48"/></td>
        </tr>
    </table>
    <table cellpadding="0" cellspacing="0" style="width:830px" border="0">
        <tr>
            <td  align="right" colspan ="2" style="width:830px;height:48px">
                <input id="btn_bookmng_submit" type="button" style=" width:70px;" value="提交" />
                <input id="btn_bookmng_cancel" type="button" style=" width:70px;" value="取消" />
            </td>
        </tr>
    </table>
    <div id="bookmng_ctlg_detail_container" class="Div_ctlg_detail_container">
        <div id="bookmng_ctlg_detail">
        </div>
        <input id="btn_detail_select" type="button" style=" width:70px;" value="确定" />
        <input id="btn_detail_cancel" type="button" style=" width:70px;" value="取消" /></div>
</form>
</body>
</html>

