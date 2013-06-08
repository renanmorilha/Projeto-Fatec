using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ALavadeiraBackEnd.Entity;
using ALavadeiraBackEnd.Data;
using System.Data;
using System.Data.SqlClient;

namespace ALavadeiraBackEnd.Data
{
    public class LoginData
    {
        private LoginEntity log = new LoginEntity();


        public LoginData(LoginEntity lg) {
            log = lg;
        }

        public bool verificaLogin() {
            DB objDB = new DB(log.cn);

            string sql = "SELECT * from usuarios where usuario = '"+log.user+"' and senha = '"+log.senha+"'";
            SqlDataReader wtbtemp = objDB.executeReader(CommandType.Text, sql);
            
            if(wtbtemp.HasRows){
                return true;
            }else{
                return false;
            }
        }


    }
}
