using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ALavadeiraBackEnd.Entity;

namespace ALavadeiraBackEnd.Data
{
    class PecasData
    {

        PecasEntity pe = new PecasEntity();

        public PecasData() { }

        public PecasData(PecasEntity p) {
            pe = p;
        }

        public long gravaPecas(){
            string sql;
            long i;
            DB objdb = new DB(pe.conn);
            sql = "INSERT INTO PECAS values('"+pe.nome+"', "+pe.valor+")";
            i = objdb.executeQuery(CommandType.Text, sql);
            return i;
        }

        public SqlDataReader consultaPecas(string conn, string nome, double valor) {
            string sql;
            DB objdb = new DB(conn);
            SqlDataReader wtb;

            sql = "SELECT * from PECAS where nome like '%"+nome+"%' and valor = "+valor;
            wtb = objdb.executeReader(CommandType.Text, sql);

            return wtb;

        }

    }
}
