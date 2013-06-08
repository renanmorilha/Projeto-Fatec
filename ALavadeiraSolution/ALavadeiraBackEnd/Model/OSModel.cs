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
    class OSModel
    {
        OSEntity ose;

        public OSModel(OSEntity oe) {
            ose = oe;
        }

        public long gravaOS(){
            if (ose.conn == ""){
                return 0;
            }

            if (ose.dataentrega == null)
            {
                return 0;
            }

            if (ose.pecas == null || ose.pecas.Count <=0)
            {
                return 0;
            }

            if (ose.pessoacod == 0)
            {
                return 0;
            }

            if (ose.valortotal == 0)
            {
                return 0;
            }

            long i;
            OSData od = new OSData(ose);
            i = od.gravaOS();
            return i;

        }

        public SqlDataReader consultaOS() {

            if (ose.pessoacod <= 0){
                ose.pessoacod = 0;
            }

            if (ose.status == "") {
                ose.status = "%";
            }

            SqlDataReader wtb;

            OSData od = new OSData(ose);
            wtb = od.consultaOS();

            return wtb;

        }

        public long alteraOS() {
            long i = 0;

            if (ose.status == "" || ose.status != "ativo" || ose.status != "Ativo" || ose.status != "Cancelada" || ose.status != "Finalizada")
            {
                return 0;
            }

            if (ose.id <=0){
                return 0;
            }


            OSData od = new OSData(ose);

            i = od.alteraOS();
            return i;

        }

    }
}
