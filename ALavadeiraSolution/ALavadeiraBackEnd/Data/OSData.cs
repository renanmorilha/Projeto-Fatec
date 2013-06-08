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
    class OSData
    {
        OSEntity ose;

        public OSData() { 
        }

        public OSData(OSEntity oe)
        {
            ose = oe;
        }

        public long gravaOS(){
            DB objdb = new DB(ose.conn);
            
            string sql;
            long i;
            SqlDataReader wtbos;
            sql = "INSERT INTO Ordem_Servicos values ("+ose.pessoacod+",'"+ose.status+"', '"+ose.dataentrega+"', "+ose.valortotal+")";
            i = objdb.executeQuery(CommandType.Text, sql);
            sql = "SELECT IDENT_CURRENT('OS') as nextcode";
            wtbos = objdb.executeReader(CommandType.Text,sql);

            if (wtbos.HasRows)
            {
                ose.id = Convert.ToInt32(wtbos["nextcode"]);
                Ospecasentity op = new Ospecasentity(ose.conn,ose);
                i = op.gravaospecas();

                return i;
            }
            else {
                return 0;
            }
            
        }

        public SqlDataReader consultaOS() {
            SqlDataReader wtb;
            string sql;
            DB objdb = new DB(ose.conn);

            sql = "SELECT os.*, op.*, p.* from Ordem_Servicos os INNER JOIN OS_PECAS op ON os.id_os = op.id_os INNER JOIN PECAS p ON p.id_peca = op.id_peca where os.id_pes = "+ose.pessoacod+" or os.status_os like "+ose.status;
            wtb = objdb.executeReader(CommandType.Text, sql);
            return wtb;

        }

        public long alteraOS() {
            long i = 0;
            string sql;

            try
            {
                DB objdb = new DB(ose.conn);
                sql = "Update Ordem_servicos set status_os = " + ose.status + " where id_os = " + ose.id;
                i = objdb.executeQuery(CommandType.Text, sql);
                return i;
            }catch(Exception ex){
                return 0;
            }
        }

    }
}
