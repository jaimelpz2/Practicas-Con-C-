﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Aplicacion3.aspx.cs" Inherits="CookiesAndSession.Aplicacion3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ingrese email:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Confirmar" />
        </div>
    </form>
</body>
</html>
