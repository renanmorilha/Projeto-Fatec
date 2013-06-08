using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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

        }
    }
}