using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ALavadeiraBackEnd.Model;
using System.Data.SqlClient;

namespace ALavadeiraBackEnd.Entity
{
    public class PecasEntity
    {

        public string nome;
        public double valor;
        public int id;
        public string conn;
        public double qtd;

        public PecasEntity() { 
            
        }

        public PecasEntity(string cn, string n, double v)
        {
            conn = cn;
            nome = n;
            valor = v;
        }

        public PecasEntity(string cn, int i, string n, double v)
        {
            id = i;
            conn = cn;
            nome = n;
            valor = v;
        }

        public long gravaPecas(){
            long i;
            PecasModel pm = new PecasModel(this);
            i = pm.gravaPecas();
            return i;
        }

        public SqlDataReader consultaPecas(string conn, string nome, double valor) {
            SqlDataReader wtb;
            PecasModel pm = new PecasModel();
            wtb = pm.consultaPecas(conn,nome,valor);
            return wtb;
        }

    }
}
