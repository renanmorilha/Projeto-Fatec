using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ALavadeiraBackEnd.Model;

namespace ALavadeiraBackEnd.Entity
{
    public class LoginEntity
    {
        public string cn;
        public string user;
        public string senha;

        public LoginEntity(string con, string us, string sen) {
            user = us;
            senha = sen;
            cn = con;
        }

        public LoginEntity()
        {
        }

        public bool validaLogin(){

            LoginModel lm = new LoginModel(this);

            if (lm.validaLogin())
            {
                return true;
            }else{
                return false;
            }
        }



    }
}
