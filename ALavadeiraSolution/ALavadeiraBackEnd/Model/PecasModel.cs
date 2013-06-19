using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ALavadeiraBackEnd.Data;
using ALavadeiraBackEnd.Entity;


namespace ALavadeiraBackEnd.Model
{
    public class PecasModel
    {

        PecasEntity pe = new PecasEntity();

        public PecasModel() { }

        public PecasModel(PecasEntity p) {
            pe = p;
        }


        public long gravaPecas(){

            if (pe.nome == ""){
                return 0;
            }

            if (pe.valor < 0){
                return 0;
            }

            PecasData pd = new PecasData(pe);
            long i;
            i = pd.gravaPecas();
            return i;

        }

        public SqlDataReader consultaPecas(string conn, string nome) {
            SqlDataReader wtb;
            PecasData pd = new PecasData();
            wtb = pd.consultaPecas(conn, nome);
            return wtb;
        }

    }
}
