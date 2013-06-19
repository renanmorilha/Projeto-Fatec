<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroPecas.aspx.cs" Inherits="ALavadeira.CadastroPecas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeaderContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Cadastro de Peças</h1>
    <hr />
    <table><tr><td>
        <b>Peça:</b>
               </td>
        <td> <asp:TextBox ID="txtPeca" runat="server"></asp:TextBox> </td></tr>
        <tr><td> <b>Valor da Peça:</b> </td>
            <td> <asp:TextBox ID="txtValor" runat="server"></asp:TextBox> </td>
        </tr></table>
    <asp:Label ID="lblErro" Visible="false" runat="server" Text="Label"></asp:Label><br />
        <asp:Button ID="btnGravar" runat="server" Text="Gravar" OnClick="btnGravar_Click" />

</asp:Content>
