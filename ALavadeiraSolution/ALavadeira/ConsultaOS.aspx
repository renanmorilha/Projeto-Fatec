<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConsultaOS.aspx.cs" Inherits="ALavadeira.ConsultaOS" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeaderContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Consulta de OS</h3><br />
    <asp:Panel ID="Panel1" runat="server"><b>Selecione o Campo: </b> <asp:DropDownList ID="cmbCampo" runat="server" Height="32px" Width="151px"></asp:DropDownList>

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Digite o Filtro:&nbsp;<asp:TextBox ID="txtfiltro" runat="server"></asp:TextBox>

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" />

    </asp:Panel><br /><br />
    <center><asp:GridView ID="GridView1" runat="server" style="text-align: center" Caption="OS" ShowFooter="True">
                <FooterStyle BackColor="#A6BCFF" />
                <HeaderStyle BackColor="#A6BCFF" />
                <RowStyle BackColor="White" BorderColor="#A6BCFF" BorderStyle="Solid" />
            </asp:GridView></center>
</asp:Content>
