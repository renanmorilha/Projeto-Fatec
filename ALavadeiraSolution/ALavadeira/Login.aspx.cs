using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using ALavadeiraBackEnd.Entity;

namespace ALavadeira
{
    public partial class Login : System.Web.UI.Page
    {

        

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            LoginEntity lg = new LoginEntity(ConfigurationManager.ConnectionStrings["Lavadeira"].ConnectionString, Login1.UserName, Login1.Password);
            e.Authenticated = lg.validaLogin();
        }
    }
}