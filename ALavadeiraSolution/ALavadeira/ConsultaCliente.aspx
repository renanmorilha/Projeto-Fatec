<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConsultaCliente.aspx.cs" Inherits="ALavadeira.ConsultaCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeaderContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Consulta de Clientes<asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    </h3><br />
    <asp:Panel ID="pnlbusca" runat="server">
        <b>Selecione um campo para buscar:</b>&nbsp;&nbsp;
        <asp:DropDownList ID="cmbCampo" runat="server" Height="24px" Width="157px">
            <asp:ListItem>Nome</asp:ListItem>
            <asp:ListItem>CPF</asp:ListItem>
            <asp:ListItem>CNPJ</asp:ListItem>
            <asp:ListItem>Status</asp:ListItem>
            <asp:ListItem Value="nome_fant">Nome Fantasia</asp:ListItem>
        </asp:DropDownList>

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <b>Digite o Filtro:</b>&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtBusca" runat="server"></asp:TextBox>&nbsp;&nbsp;
        <asp:Button ID="btnBusca" runat="server" Text="Buscar" OnClick="btnBusca_Click" />
    </asp:Panel><br />
    <center><asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:GridView ID="GridView1" runat="server" style="text-align: center" Caption="Clientes" ShowFooter="True" Visible="False" AutoGenerateColumns="False" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
                <FooterStyle BackColor="#A6BCFF" />
                <HeaderStyle BackColor="#A6BCFF" />
                <RowStyle BackColor="White" BorderColor="#A6BCFF" BorderStyle="Solid" />
                <Columns>

                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnEdit" CommandName="Edit" runat="server" Text="Editar"></asp:Button> 
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:Button ID="btnUpdate" CommandName="Update" runat="server" Text="Alterar"></asp:Button> 
                            <asp:Button ID="btnCancel" CommandName="Cancel" runat="server" Text="Cancelar"></asp:Button> 
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Codigo">
                        <ItemTemplate>
                            <asp:Label ID="lblCod" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.id_pes") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Nome">
                        <ItemTemplate>
                            <asp:Label ID="lblNome" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Nome") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtNome" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Nome") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="CPF">
                        <ItemTemplate>
                            <asp:Label ID="lblCPF" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.CPF") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtCPF" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.CPF") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="RG">
                        <ItemTemplate>
                            <asp:Label ID="lblRG" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.RG") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtRG" MaxLength="9" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.RG") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Data Nasc.">
                        <ItemTemplate>
                            <asp:Label ID="lblDataNasc" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.data_nasc") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtDataNasc" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.data_nasc") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Status">
                        <ItemTemplate>
                            <asp:DropDownList ID="cmbStatus" Enabled="false" runat="server" SelectedValue='<%# DataBinder.Eval(Container, "DataItem.status_pes") %>'>
                                <asp:ListItem value="Ativo">Ativo</asp:ListItem>
                                <asp:ListItem value="Inativo">Inativo</asp:ListItem>
                            </asp:DropDownList>
                        </ItemTemplate>
                        <EditItemTemplate>
                         <asp:DropDownList ID="cmbStatuse" runat="server" SelectedValue='<%# DataBinder.Eval(Container, "DataItem.status_pes") %>'>
                                <asp:ListItem value="Ativo">Ativo</asp:ListItem>
                                <asp:ListItem value="Inativo">Inativo</asp:ListItem>
                            </asp:DropDownList>
                        </EditItemTemplate>
                    </asp:TemplateField>

                </Columns>
            </asp:GridView>

            <asp:GridView ID="GridView2" runat="server" style="text-align: center" Caption="Clientes" ShowFooter="True" Visible="False" AutoGenerateColumns="False" OnRowCancelingEdit="GridView2_RowCancelingEdit" OnRowEditing="GridView2_RowEditing" OnRowUpdating="GridView2_RowUpdating">
                <FooterStyle BackColor="#A6BCFF" />
                <HeaderStyle BackColor="#A6BCFF" />
                <RowStyle BackColor="White" BorderColor="#A6BCFF" BorderStyle="Solid" />
                <Columns>

                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnEdit" CommandName="Edit" runat="server" Text="Editar"></asp:Button> 
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:Button ID="btnUpdate" CommandName="Update" runat="server" Text="Alterar"></asp:Button> 
                            <asp:Button ID="btnCancel" CommandName="Cancel" runat="server" Text="Cancelar"></asp:Button> 
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Codigo">
                        <ItemTemplate>
                            <asp:Label ID="lblCod" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.id_pes") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Nome Fant.">
                        <ItemTemplate>
                            <asp:Label ID="lblNomeFant" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.nome_fant") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtNomeFant" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.nome_fant") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="CNPJ">
                        <ItemTemplate>
                            <asp:Label ID="lblCNPJ" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.CNPJ") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtCNPJ" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.cnpj") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="IE">
                        <ItemTemplate>
                            <asp:Label ID="lblIE" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.IE") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtie" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.ie") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Razão Social">
                        <ItemTemplate>
                            <asp:Label ID="lblRazSoc" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.razao_social") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtRazSoc" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.razao_social") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Status">
                        <ItemTemplate>
                            <asp:DropDownList Enabled="false" ID="cmbStatus" runat="server" SelectedValue='<%# DataBinder.Eval(Container, "DataItem.pes_status") %>'>
                                <asp:ListItem value="Ativo">Ativo</asp:ListItem>
                                <asp:ListItem value="Inativo">Inativo</asp:ListItem>
                            </asp:DropDownList>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:DropDownList ID="cmbStatuse" runat="server" SelectedValue='<%# DataBinder.Eval(Container, "DataItem.pes_status") %>'>
                                <asp:ListItem value="Ativo">Ativo</asp:ListItem>
                                <asp:ListItem value="Inativo">Inativo</asp:ListItem>
                            </asp:DropDownList>
                        </EditItemTemplate>
                    </asp:TemplateField>

                </Columns>
            </asp:GridView>

        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="btnBusca" EventName="Click">
            </asp:AsyncPostBackTrigger>
        </Triggers>
    </asp:UpdatePanel></center>
    <br />


</asp:Content>
