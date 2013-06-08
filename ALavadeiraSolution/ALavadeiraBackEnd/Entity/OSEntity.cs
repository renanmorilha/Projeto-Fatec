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
    public class OSEntity
    {
        public int id;
        public int pessoacod;
        public string pessoa;
        public List<PecasEntity> pecas;
        public DateTime dataentrega;
        public double valortotal;
        public string conn;
        public string status;

        public OSEntity() { 

        }

        public OSEntity(string cn, int i, int pescod, List<PecasEntity> peca, DateTime dt, double valtot, string stat)
        {
            id = i;
            conn = cn;
            pessoacod = pescod;
            pecas = peca;
            dataentrega = dt;
            valortotal = valtot;
            status = stat;
        }

        public OSEntity(string cn, int pescod, List<PecasEntity> peca, DateTime dt, double valtot, string stat)
        {
            conn = cn;
            pessoacod = pescod;
            pecas = peca;
            dataentrega = dt;
            valortotal = valtot;
            status = stat;
        }

        public long gravaOs() {
            long i;
            OSModel om = new OSModel(this);
            i = om.gravaOS();
            return i;
        }

        public SqlDataReader consultaOS() {
            SqlDataReader wtb;
            OSModel om = new OSModel(this);
            wtb = om.consultaOS();
            return wtb;
        }

        public long alteraOS() {
            long i;

            OSModel om = new OSModel(this);
            i = om.alteraOS();
            return i;

        }



    }
}
