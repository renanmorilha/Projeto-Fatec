<%@ Page Title="Cadastro de Clientes" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroClientes.aspx.cs" Inherits="ALavadeira.CadastroClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeaderContent" runat="server">
    <style type="text/css">
        .auto-style1
        {
            width: 86px;
        }
        .auto-style2
        {
            width: 144px;
        }
        .auto-style3
        {
            width: 146px;
            height: 22px;
        }
        .auto-style4
        {
            height: 22px;
        }
        .auto-style5
        {
            width: 146px;
        }
    </style>
 </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Cadastro de Clientes<asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="True" LoadScriptsBeforeUI="False">
        </asp:ScriptManager>
    </h3>

    <asp:RadioButtonList ID="rdbPes" runat="server" BorderColor="Gray" BorderStyle="Solid" BorderWidth="2px" OnSelectedIndexChanged="rdbPes_SelectedIndexChanged" AutoPostBack="True">
        <asp:ListItem Value="F">Pessoa Física</asp:ListItem>
        <asp:ListItem Value="J">Pessoa Jurídica</asp:ListItem>
    </asp:RadioButtonList><br />
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>

            <asp:Panel ID="pnlFis" runat="server" Visible="false">
                <h3>Pessoa Física</h3>
                <table>
                    <tr>
                        <td class="auto-style5"><b>Nome:</b></td><td><asp:TextBox ID="txtNome" runat="server" Width="318px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><b>CPF:</b></td><td class="auto-style4"><asp:TextBox ID="txtCPF" runat="server" Width="318px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style5"><b>Data Nasc.:</b></td><td><asp:TextBox ID="txtDataNasc" runat="server" Width="318px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style5"><b>RG:</b></td><td><asp:TextBox ID="txtRg" runat="server" Width="318px"></asp:TextBox></td>
                    </tr>
                </table>
            </asp:Panel>
            <asp:Panel ID="pnlJur" runat="server" Visible="false">
                <h3>Pessoa Jurídica</h3>
                <table>
                    <tr>
                        <td><b>Nome Fantasia:</b></td><td><asp:TextBox ID="txtnomefant" runat="server" Width="318px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td><b>Razão Social:</b></td><td><asp:TextBox ID="txtRazSoc" runat="server" Width="318px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td><b>CNPJ:</b></td><td><asp:TextBox ID="txtCnpj" runat="server" Width="318px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:CheckBox ID="chkie" runat="server" Text="É isento de I.E. ?" AutoPostBack="True" OnCheckedChanged="chkie_CheckedChanged" /></td>
                    </tr>
                    <tr>
                        <td><b>Inscrição Estadual:</b></td><td>
                        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                            <ContentTemplate>
                                <asp:TextBox ID="txtie" runat="server" Width="318px"></asp:TextBox>
                            </ContentTemplate>
                            <Triggers>
                                <asp:AsyncPostBackTrigger ControlID="chkie" EventName="CheckedChanged" />
                            </Triggers>
                        </asp:UpdatePanel>
                        </td>
                    </tr>
                </table>
            </asp:Panel>
            <br />

            <asp:Panel ID="pnlComum" runat="server" Visible="false">
                <h3>Dados Pessoais</h3><br />
                <table>
                    <tr><td class="auto-style2"><b>Endereço:</b></td><td>
                        <asp:TextBox ID="txtender" runat="server" Width="300px"></asp:TextBox></td></tr>
                    <tr><td class="auto-style2"><b>Bairro:</b></td><td>
                        <asp:TextBox ID="txtbair" runat="server" Width="300px"></asp:TextBox></td></tr>
                    <tr><td class="auto-style2"><b>Número:</b></td><td>
                        <asp:TextBox ID="txtNum" runat="server" Width="300px"></asp:TextBox></td></tr>
                    <tr><td class="auto-style2"><b>Complemento:</b></td><td>
                        <asp:TextBox ID="txtComp" runat="server" Width="300px"></asp:TextBox></td></tr>
                    <tr><td class="auto-style2"><b>Cidade:</b></td><td>
                        <asp:TextBox ID="txtcidade" runat="server" Width="300px"></asp:TextBox></td></tr>
                    <tr><td class="auto-style2"><b>UF:</b></td><td>
                        <asp:DropDownList ID="cmbUF" runat="server" Height="19px" Width="198px"></asp:DropDownList></td></tr>
                    <tr><td class="auto-style2"><b>Telefone:</b></td><td>
                        <asp:TextBox ID="txtfone" runat="server" Width="300px"></asp:TextBox></td></tr>
                </table>
            </asp:Panel>
<br />
            <asp:Panel ID="pnlConf" runat="server" Visible="false">
                <asp:Button ID="btnCad" runat="server" Text="Cadastrar" OnClick="btnCad_Click" /><br />
                <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                    <ContentTemplate>
                        <div id="divLabel"><asp:Label ID="lblErro" runat="server" Text="Label" style="font-size: xx-large; font-weight: 700; text-decoration: underline" Visible="False"></asp:Label></div>
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="btnCad" EventName="Click" />
                    </Triggers>
                </asp:UpdatePanel>
            </asp:Panel>

        </ContentTemplate>
        


        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="rdbPes" EventName="SelectedIndexChanged" />
        </Triggers>
        


    </asp:UpdatePanel>
    
</asp:Content>
