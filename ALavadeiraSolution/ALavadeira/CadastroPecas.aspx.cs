using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;
using System.Globalization;
using ALavadeiraBackEnd.Entity;
using System.Configuration;


namespace ALavadeira
{
    public partial class CadastroPecas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGravar_Click(object sender, EventArgs e)
        {
            lblErro.Visible = false;
            PecasEntity pecas = new PecasEntity();
            pecas.conn = ConfigurationManager.ConnectionStrings["Lavadeira"].ConnectionString;
            pecas.nome = txtPeca.Text;
            try
            {

                pecas.valor = decimal.Parse(txtValor.Text);
                long i;
                i = pecas.gravaPecas();

                if (i == 0)
                {
                    lblErro.Text = "Erro Ao Gravar Peça";
                    lblErro.Visible = true;
                }
                else {
                    lblErro.Text = "Peça Gravada Com Sucesso";
                    lblErro.Visible = true;
                }

            }
            catch {
                lblErro.Text = "Valor Digitado Incorreto";
                lblErro.Visible = true;
            }
        }
    }
}