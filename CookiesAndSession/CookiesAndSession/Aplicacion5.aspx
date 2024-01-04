<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Aplicacion5.aspx.cs" Inherits="CookiesAndSession.Aplicacion5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            Los datos almacenados enlas variables de sesion:</p>
        <p>
            <asp:Label ID="Lusuario" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Lclave" runat="server"></asp:Label>
        </p>
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Aplicacion6.aspx">Siguiente </asp:HyperLink>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
