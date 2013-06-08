<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ALavadeira.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head><title>
	Login do Usuário
</title>
    <style type="text/css">
        .style1
        {
            width: 340px;
        }
        .style7
        {
            text-align: center;
        }
        .style8
        {
            width: 346px;
        }
        .style9
        {
            font-family: "Comic Sans MS";
            color: #808080;
        }
        .style10
        {
            font-family: "Comic Sans MS";
            color: #808080;
            font-size: x-large;
        }
        .style11
        {
            width: 8px;
        }

        table
        {
            border-radius:20px;
        }

        input
        {
            border-radius:20px;
        }

        submit
        {
            border-radius:20px;
        }

        .submitbutton
        {
            border-radius:20px;
        }

        .submit
        {
            border-radius:20px;
        }

        select
        {
            border-radius:20px;
        }

        </style>

</head>
<body style="background-color:#f4fbfe">
    
        <form id="form1" runat="server">
    <div class="header"><img src="images/banner.png" style="height: 236px; width: 100%" /></div><br />
        <center>
                <asp:Login ID="Login1" runat="server" BorderColor="#6699FF" BorderStyle="Solid" DestinationPageUrl="Default.aspx" DisplayRememberMe="False" FailureText="Falha no Login, por favor, tente novamente." Font-Names="Calibri" ForeColor="Black" Height="170px" LoginButtonText="Entrar" MembershipProvider="Forms" OnAuthenticate="Login1_Authenticate" PasswordLabelText="Senha:" PasswordRequiredErrorMessage="Senha é necessária" TitleText="Autenticação" UserNameLabelText="Usuário:" UserNameRequiredErrorMessage="usuário necessário" Width="314px" BackColor="#E2E2E2" BorderPadding="3" BorderWidth="1px">
                    <TextBoxStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="200px" />
                    <TitleTextStyle BackColor="#69C9F1" BorderColor="#0000CC" BorderStyle="Solid" BorderWidth="1px" ForeColor="White" Height="20px" HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:Login>
            </center>
            <br /><hr />
            <div>A Lavadeira<br />
Software desenvolvido por grupo de alunos da Faculdade de Tecnologia de São José do Rio Preto<br />Análise e Desenvolvimento de Sistemas </div>
    </form>
</body>
</html>
