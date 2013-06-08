<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConsultaCliente.aspx.cs" Inherits="ALavadeira.ConsultaCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeaderContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Consulta de Clientes</h3><br />
    <asp:Panel ID="pnlbusca" runat="server">
        <b>Selecione um campo para buscar:</b>&nbsp;&nbsp;
        <asp:DropDownList ID="cmbCampo" runat="server" Height="24px" Width="157px">
            <asp:ListItem>Nome</asp:ListItem>
            <asp:ListItem>CPF</asp:ListItem>
            <asp:ListItem>CNPJ</asp:ListItem>
            <asp:ListItem>Status</asp:ListItem>
        </asp:DropDownList>

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <b>Digite o Filtro:</b>&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtBusca" runat="server"></asp:TextBox>&nbsp;&nbsp;
        <asp:Button ID="btnBusca" runat="server" Text="Buscar" OnClick="btnBusca_Click" />
    </asp:Panel><br />
    <center><asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:GridView ID="GridView1" runat="server" style="text-align: center" Caption="Clientes" ShowFooter="True" Visible="False">
                <FooterStyle BackColor="#A6BCFF" />
                <HeaderStyle BackColor="#A6BCFF" />
                <RowStyle BackColor="White" BorderColor="#A6BCFF" BorderStyle="Solid" />
            </asp:GridView>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="btnBusca" EventName="Click">
            </asp:AsyncPostBackTrigger>
        </Triggers>
    </asp:UpdatePanel></center>
    <br />


</asp:Content>
