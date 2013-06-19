using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ALavadeiraBackEnd.Model;
using System.Data;
using System.Data.SqlClient;

namespace ALavadeiraBackEnd.Entity
{
    public class Ospecasentity
    {
        public OSEntity ose;
        public decimal precototal;
        public string conn;

        public Ospecasentity() { }

        public Ospecasentity(string cn, OSEntity os) {
            ose = os;
            conn = cn;
        }

        public long gravaospecas(){
            Ospecasmodel opm = new Ospecasmodel(this);
            long i;
            i = opm.gravaospecas();
            return i;
        }

        public SqlDataReader consultaOsPecas() {
            SqlDataReader wtb;
            Ospecasmodel opm = new Ospecasmodel(this);
            wtb = opm.consultaOsPecas();
            return wtb;
        }

    }
}
