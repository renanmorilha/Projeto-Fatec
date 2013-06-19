using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ALavadeiraBackEnd.Entity;
using System.Configuration;
using System.Data.SqlClient;

namespace ALavadeira
{
    public partial class ConsultaPecas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            PecasEntity pecas = new PecasEntity();
            SqlDataReader wtbtemp;
            wtbtemp = pecas.consultaPecas(ConfigurationManager.ConnectionStrings["Lavadeira"].ConnectionString,"%%");

            grdPecas.DataSource = wtbtemp;
            grdPecas.DataBind();

        }
    }
}