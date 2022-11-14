<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmLogin.aspx.cs" Inherits="ProyectoSeguridad.frmLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Login runat="server" ID="login1" OnAuthenticate="login1_Authenticate">

    </asp:login>
</asp:Content>
