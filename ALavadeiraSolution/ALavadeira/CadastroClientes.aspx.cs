using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ALavadeiraBackEnd.Entity;
using System.Configuration;

namespace ALavadeira
{
    public partial class CadastroClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void rdbPes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdbPes.SelectedValue == "F")
            {
                pnlFis.Visible = true;
                pnlJur.Visible = false;
            }
            else
            {
                pnlFis.Visible = false;
                pnlJur.Visible = true;
            }
            pnlComum.Visible = true;
            pnlConf.Visible = true;
        }

        protected void chkie_CheckedChanged(object sender, EventArgs e)
        {
            if (chkie.Checked == true){
                txtie.Enabled = false;
            }else{
                txtie.Enabled = true;
            }
        }

        protected void btnCad_Click(object sender, EventArgs e)
        {
            lblErro.Visible = false;
            if (rdbPes.SelectedValue == "F"){
                PessoaFisicaEntity pf = new PessoaFisicaEntity();
                long i;

                pf.conn = ConfigurationManager.ConnectionStrings["Lavadeira"].ConnectionString;
                pf.bairro = txtbair.Text;
                pf.cep = "15050200";
                pf.cpf = txtCPF.Text;
                pf.datanasc = Convert.ToDateTime(txtDataNasc.Text);
                pf.ddd = Convert.ToInt32(txtddd.Text);
                pf.endereco = txtender.Text;
                pf.nome = txtNome.Text;
                pf.numero = txtNum.Text;
                pf.rg = txtRg.Text;
                pf.status = "Ativo";
                pf.telefone = txtfone.Text;
                i=pf.gravaPesFis();
                
                if (i == 0) {
                    lblErro.Text = "Ocorreu um Erro durante a gravação, por favor verifica se os dados estão corretos";
                    lblErro.Visible = true;
                }else{
                    txtbair.Text = "";
                    txtcidade.Text = "";
                    txtComp.Text = "";
                    txtCPF.Text = "";
                    txtDataNasc.Text = "";
                    txtender.Text = "";
                    txtfone.Text = "";
                    txtNome.Text = "";
                    txtNum.Text = "";
                    txtRg.Text = "";
                    txtRazSoc.Text = "";
                    txtCnpj.Text = "";
                    txtie.Text = "";
                    txtnomefant.Text = "";
                    txtddd.Text = "";
                    txtcep.Text = "";
                    lblErro.Text = "Pessoa Gravada com Sucesso !";
                    lblErro.Visible = true;
                }

            }else if(rdbPes.SelectedValue == "J"){
                PessoaJuridicaEntity pj = new PessoaJuridicaEntity();
                long i;

                pj.conn = ConfigurationManager.ConnectionStrings["Lavadeira"].ConnectionString;
                pj.bairro = txtbair.Text;
                pj.cep = "15050200";
                pj.cnpj = txtCnpj.Text;
                pj.ddd = Convert.ToInt32(txtddd.Text);
                pj.endereco = txtender.Text;
                pj.ie = txtie.Text;
                pj.nomefant = txtnomefant.Text;
                pj.numero = txtNum.Text;
                pj.razsoc = txtRazSoc.Text;
                pj.status = "Ativo";
                pj.telefone = txtfone.Text;

                i=pj.gravaPesJur();
                if (i == 0){
                    lblErro.Text = "Ocorreu um Erro ao gravar esta Pessoa, por favor, verifique os dados";
                    lblErro.Visible = true;
                }else{
                    txtbair.Text = "";
                    txtcidade.Text = "";
                    txtComp.Text = "";
                    txtCPF.Text = "";
                    txtDataNasc.Text = "";
                    txtender.Text = "";
                    txtfone.Text = "";
                    txtNome.Text = "";
                    txtNum.Text = "";
                    txtRg.Text = "";
                    txtRazSoc.Text = "";
                    txtCnpj.Text = "";
                    txtie.Text = "";
                    txtnomefant.Text = "";
                    txtddd.Text = "";
                    txtcep.Text = "";
                    lblErro.Text = "Pessoa Gravada com Sucesso !";
                    lblErro.Visible = true;
                }
            }

        }
    }
}