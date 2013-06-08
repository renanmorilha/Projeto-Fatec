<%@ Page Title="Cadastro de OS" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroOS.aspx.cs" Inherits="ALavadeira.CadastroOS" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeaderContent" runat="server">
    <style type="text/css">
        .auto-style1
        {
            width: 135px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Cadastro de OS<asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    </h3><br />
    <asp:Panel ID="Panel1" runat="server">
        <table>
            <tr><td class="auto-style1"><b>Cliente (codigo):</b></td><td>
                <asp:TextBox ID="Txtcliente" runat="server"></asp:TextBox></td></tr>
            <tr><td class="auto-style1"><b>Data da Entrega:</b></td><td>
                <asp:TextBox ID="txtdata" runat="server"></asp:TextBox></td></tr>
        </table><br />
        <h3>Peças</h3><br />
        <table>
            <tr><td><b>Peça:</b></td><td>
                <asp:DropDownList ID="cmbPeca" runat="server" Height="29px" Width="141px"></asp:DropDownList>
                </td></tr>
            <tr><td><b>Quantidade:</b></td><td>
                <asp:TextBox ID="txtqtd" runat="server"></asp:TextBox></td></tr>
            <tr><td>
                <asp:Button ID="btnadd" runat="server" Text="Adicionar Peça" /></td></tr>
        </table><br />

        <center><asp:GridView ID="GridView1" runat="server" style="text-align: center" Caption="Produtos" ShowFooter="True" Visible="False">
                <FooterStyle BackColor="#A6BCFF" />
                <HeaderStyle BackColor="#A6BCFF" />
                <RowStyle BackColor="White" BorderColor="#A6BCFF" BorderStyle="Solid" />
            </asp:GridView></center><br /><br />
        <b>Valor:</b><asp:Label ID="lblValor" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Button ID="btnregistrar" runat="server" Enabled="False" Text="Registrar" />
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="btnadd" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="GridView1" EventName="RowDeleting" />
            </Triggers>
        </asp:UpdatePanel>
        <br />


    </asp:Panel>
</asp:Content>
