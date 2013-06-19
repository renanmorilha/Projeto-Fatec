using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ALavadeiraBackEnd.Entity;
using ALavadeiraBackEnd.Data;
using System.Data;
using System.Data.SqlClient;

namespace ALavadeiraBackEnd.Model
{
    public class Ospecasmodel
    {
        Ospecasentity ose;

        public Ospecasmodel(){}

        public Ospecasmodel(Ospecasentity oe)
        {
            ose = oe;
        }

        public long gravaospecas(){

            if (ose.ose == null ){
                return 0;
            }

            if (ose.conn == ""){
                return 0;
            }

            //calculando Preço Total
            if (ose.precototal == 0) {
                int k =0;
                decimal precototal = 0;

                while (ose.ose.pecas.Count > 0) {
                    precototal = precototal + (ose.ose.pecas[k].qtd * ose.ose.pecas[k].valor);
                    k=k+1;
                }
                ose.precototal = precototal;
            }


            OspecasData od = new OspecasData(ose);
            long i;
            i=od.gravaospecas();
            return i;
        }

        public SqlDataReader consultaOsPecas() {
            SqlDataReader wtb;
            OspecasData opd = new OspecasData(ose);
            wtb = opd.consultaOsPecas();
            return wtb;
        }


    }
}
