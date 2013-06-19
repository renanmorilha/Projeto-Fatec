<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConsultaPecas.aspx.cs" Inherits="ALavadeira.ConsultaPecas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeaderContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Consulta de Peças</h1>
    <hr />

  <center>  <asp:GridView ID="grdPecas" runat="server" style="text-align: center" Caption="Peças" ShowFooter="True" AutoGenerateColumns="False" >
                <FooterStyle BackColor="#A6BCFF" />
                <HeaderStyle BackColor="#A6BCFF" />
                <RowStyle BackColor="White" BorderColor="#A6BCFF" BorderStyle="Solid" />

                <Columns>
                    <asp:TemplateField HeaderText="Peça">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.descricao") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:BoundField HeaderText="Valor" DataField="preco_peca" />
                </Columns>

    </asp:GridView>
    </center>
</asp:Content>
