<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Login2.Registro" UnobtrusiveValidationMode="None" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="Button1" runat="server" Text="Registrar" OnClick="Button1_Click" class="btn btn-success " /><br />
    <a  href="Login.aspx">Ya tiene cuenta?</a>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    
    <asp:TextBox ID="TextBox1" runat="server" class="form-control"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Usuario es requerido" ForeColor="Red" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
</asp:Content>


<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder6" runat="server">
    
    <asp:TextBox ID="TextBox2" runat="server" class="form-control"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Contraseña es requerido" ForeColor="Red" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
</asp:Content>



