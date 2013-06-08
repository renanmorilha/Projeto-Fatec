using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ALavadeiraBackEnd.Data;
using ALavadeiraBackEnd.Entity;

namespace ALavadeiraBackEnd.Model
{
    public class LoginModel
    {
        private string cn;
        private LoginEntity log = new LoginEntity();

        public LoginModel(LoginEntity lg) {
            log = lg;
        }

        public bool validaLogin(){

            

            if ((log.user != "" || log.user != null) && (log.senha != "" || log.senha != null) && (log.senha.Length > 4 && log.user.Length > 8)){

                log.user = log.user.Replace("'","");
                log.senha = log.senha.Replace("'", "");

                LoginData ld = new LoginData(log);
                if (ld.verificaLogin())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }else{
                return false;
            }
        }


    }
}
