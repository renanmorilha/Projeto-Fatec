using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ALavadeiraBackEnd.Entity;
using System.Data;
using System.Data.SqlClient;

namespace ALavadeiraBackEnd.Data
{
    public class OspecasData
    {
        Ospecasentity ose;
        public OspecasData() { }

        public OspecasData(Ospecasentity oe)
        {
            ose = oe;
        }

        public long gravaospecas(){
            
            DB objdb = new DB(ose.conn);
            long i=0;
            int k=0;
            string sql;

            while (k < ose.ose.pecas.Count) {
                sql = "INSERT INTO OS_PECAS values (" + ose.ose.id;
                PecasEntity p = new PecasEntity();
                p = ose.ose.pecas[k];
                sql = sql + ", " + p.id + ", "+p.qtd+", "+ose.precototal+")";
                i = objdb.executeQuery(CommandType.Text,sql);
                sql = "";
                k = k + 1;
            }

            return i;

        }

        public SqlDataReader consultaOsPecas() {
            SqlDataReader wtb;
            string sql;
            DB objdb = new DB(ose.conn);


            sql = "SELECT * from OS_PECAS where id_os = "+ose.ose.id;
            wtb = objdb.executeReader(CommandType.Text, sql);
            return wtb;

        }

    }
}
