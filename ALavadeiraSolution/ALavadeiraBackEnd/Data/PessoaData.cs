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
    public class PessoaData
    {
        private PessoaEntity pe;

        public PessoaData(PessoaEntity p) {
            pe = p;
        }

        public SqlDataReader gravaPessoa(){
            SqlDataReader wtbpesdata;
            DB objDb = new DB(pe.conn);
            long i;

            string sql = "INSERT INTO Pessoas values('"+pe.status+"', '"+pe.endereco+"', '"+pe.bairro+"', '"+pe.numero+"', '"+pe.cep+"', "+pe.ddd+", '"+pe.telefone+"')";
            i = objDb.executeQuery(CommandType.Text, sql);
            if (i != 0)
            {
                sql = "SELECT IDENT_CURRENT('PESSOAS') as nextcode";
                wtbpesdata = objDb.executeReader(CommandType.Text,sql);
                return wtbpesdata;
            }
            else {
                return null;
            }

        }

        public long alterandoPessoa() {
            DB objDB = new DB(pe.conn);
            string sql = "";
            long i;
            SqlDataReader wtb;
            sql = "select * from pessoas where id_pes = " + pe.id;
            wtb = objDB.executeReader(CommandType.Text,sql);

            if (wtb.HasRows) {
                sql = "UPDATE Pessoas set status_pes = '" + pe.status + "' where id_pes = "+pe.id;
                i = objDB.executeQuery(CommandType.Text, sql);
                return i;
            }else{
                return 0;
            }
        }


    }
}
