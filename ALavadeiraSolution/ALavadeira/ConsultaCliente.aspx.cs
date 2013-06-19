using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using ALavadeiraBackEnd.Entity;
using System.Data.SqlClient;
using System.Data.Sql;


namespace ALavadeira
{
    public partial class ConsultaCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBusca_Click(object sender, EventArgs e)
        {
            bindCampos();
            
        }

        protected void GridView2_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            PessoaJuridicaEntity pj = new PessoaJuridicaEntity();
            pj.conn = ConfigurationManager.ConnectionStrings["Lavadeira"].ConnectionString;

            Label codigo=(Label)GridView2.Rows[e.RowIndex].Cells[0].FindControl("lblCod");
            pj.id = Convert.ToInt32(codigo.Text);

            TextBox NomeFant = (TextBox)GridView2.Rows[e.RowIndex].Cells[0].FindControl("txtnomefant");
            pj.nomefant = NomeFant.Text;

            TextBox cnpj = (TextBox)GridView2.Rows[e.RowIndex].Cells[0].FindControl("txtcnpj");
            pj.cnpj = cnpj.Text;

            TextBox ie = (TextBox)GridView2.Rows[e.RowIndex].Cells[0].FindControl("txtIE");
            pj.ie = ie.Text;

            TextBox razaosocial = (TextBox)GridView2.Rows[e.RowIndex].Cells[0].FindControl("txtrazaosoc");
            pj.razsoc = razaosocial.Text;

            DropDownList status = (DropDownList)GridView2.Rows[e.RowIndex].Cells[0].FindControl("cmbStatuse");
            pj.status = status.SelectedValue;
            
            long i;
            i = pj.alterandoPesJur();

            GridView2.EditIndex = -1;
            bindCampos();
        }

        protected void GridView2_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView2.EditIndex = e.NewEditIndex;
            bindCampos();
        }

        protected void GridView2_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            e.Cancel = true;
            GridView2.EditIndex = -1;
            bindCampos();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            PessoaFisicaEntity pf = new PessoaFisicaEntity();
            pf.conn = ConfigurationManager.ConnectionStrings["Lavadeira"].ConnectionString;

            Label codigo = (Label)GridView1.Rows[e.RowIndex].Cells[0].FindControl("lblCod");
            pf.id = Convert.ToInt32(codigo.Text);

            TextBox Nome = (TextBox)GridView1.Rows[e.RowIndex].Cells[0].FindControl("txtnome");
            pf.nome = Nome.Text;

            TextBox cpf = (TextBox)GridView1.Rows[e.RowIndex].Cells[0].FindControl("txtcpf");
            pf.cpf = cpf.Text;

            TextBox rg = (TextBox)GridView1.Rows[e.RowIndex].Cells[0].FindControl("txtrg");
            pf.rg = rg.Text;

            TextBox datanasc = (TextBox)GridView1.Rows[e.RowIndex].Cells[0].FindControl("txtdatanasc");
            pf.datanasc = Convert.ToDateTime(datanasc.Text);

            DropDownList status = (DropDownList)GridView1.Rows[e.RowIndex].Cells[0].FindControl("cmbStatuse");
            pf.status = status.SelectedValue;

            long i;
            i = pf.alterandoPesFis();

            GridView1.EditIndex = -1;
            bindCampos();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            bindCampos();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            e.Cancel = true;
            GridView1.EditIndex = -1;
            bindCampos();
        }

        protected void bindCampos()
        {
            PessoaFisicaEntity pf = new PessoaFisicaEntity();
            PessoaJuridicaEntity pj = new PessoaJuridicaEntity();



            if (cmbCampo.SelectedValue == "CPF" || cmbCampo.SelectedValue == "Nome")
            {
                SqlDataReader wtbpf;
                wtbpf = pf.consultaPesFis(ConfigurationManager.ConnectionStrings["Lavadeira"].ConnectionString, "pf." + cmbCampo.SelectedValue, txtBusca.Text);

                if (wtbpf != null)
                {
                    GridView1.DataSource = wtbpf;
                    GridView1.DataBind();
                    GridView1.Visible = true;
                    GridView2.Visible = true;
                }

            }
            else if (cmbCampo.SelectedValue == "CNPJ" || cmbCampo.SelectedValue == "nome_fant")
            {
                SqlDataReader wtbpj;
                wtbpj = pj.consultaPesJur(ConfigurationManager.ConnectionStrings["Lavadeira"].ConnectionString, "pj." + cmbCampo.SelectedValue, txtBusca.Text);

                if (wtbpj != null)
                {
                    GridView2.DataSource = wtbpj;
                    GridView2.DataBind();
                    GridView2.Visible = true;
                    GridView1.Visible = false;
                }

            }
            
        }

    }
}