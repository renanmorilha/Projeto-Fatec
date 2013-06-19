using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ALavadeiraBackEnd.Entity;

namespace ALavadeiraBackEnd.Data
{
    class PessoaFisicaData
    {

        PessoaFisicaEntity pf;
        

        public PessoaFisicaData(PessoaFisicaEntity p) {
            pf = p;
        }

        public PessoaFisicaData()
        {
            
        }

        public long gravaPessoaFisica() {
            DB objDB = new DB(pf.conn);
            SqlDataReader wtbtemp;
            string sql = "";
            long i;
                sql = "INSERT INTO Pes_Fisica values (" + pf.id + ", '" + pf.nome + "', '" + pf.cpf + "', " + pf.datanasc.ToShortDateString().ToString().Replace("/","-") + ", '" + pf.rg + "')";
                i = objDB.executeQuery(CommandType.Text, sql);
                return i;
        }

        public SqlDataReader consultaPessoaFisica(string cn, string campo, string busca) {
            SqlDataReader wtbpesfis;
            DB objDB = new DB(cn);
            string sql = "";
            sql = "SELECT pf.*, p.* FROM Pessoas p INNER JOIN Pes_Fisica pf ON p.id_pes = pf.id_pes where "+campo+" like '"+busca+"%'";
            wtbpesfis = objDB.executeReader(CommandType.Text,sql);

            if (wtbpesfis != null || wtbpesfis.HasRows)
            {
                return wtbpesfis;
            }
            else {
                return null;
            }
        }

        public PessoaFisicaEntity carregaPesFis (string cn, int id){
            SqlDataReader wtbpesfis;
            DB objDB = new DB(cn);
            PessoaFisicaEntity pf = new PessoaFisicaEntity();
            string sql = "";
            sql = "SELECT pf.*, p.* FROM Pessoas p INNER JOIN Pes_Fisica pf ON p.id_pes = pf.id_pes where pf.id_pes like "+id;
            wtbpesfis = objDB.executeReader(CommandType.Text, sql);

            if (wtbpesfis.HasRows){
                pf.bairro = Convert.ToString(wtbpesfis["bairro"]);
                pf.cep =Convert.ToString(wtbpesfis["cep"]);
                pf.cpf = Convert.ToString(wtbpesfis["cpf"]);
                pf.datanasc = Convert.ToDateTime(wtbpesfis["data_nasc"]);
                pf.ddd = Convert.ToInt32(wtbpesfis["ddd"]);
                pf.endereco = Convert.ToString(wtbpesfis["endereco"]);
                pf.id = Convert.ToInt32(wtbpesfis["pf.id_pes"]);
                pf.nome = Convert.ToString(wtbpesfis["nome"]);
                pf.numero = Convert.ToString(wtbpesfis["numero"]);
                pf.rg = Convert.ToString(wtbpesfis["rg"]);
                pf.status = Convert.ToString(wtbpesfis["status_pes"]);
                pf.telefone = Convert.ToString(wtbpesfis["telefone"]);
                return pf;
            }else{
                return null;
            }
        }

        public long alterandoPesFis() {
            DB objDB = new DB(pf.conn);
            string sql = "";
            long i;
            long y;
            y = pf.alterandoPessoa();
            if (y == 1) {
                sql = "UPDATE Pes_Fisica set nome = '" + pf.nome + "', cpf = '" + pf.cpf + "', data_nasc = " + pf.datanasc.ToString("dd/MM/yyyy") + " , rg = '" + pf.rg + "' where id_pes = '" + pf.id + "'";
                i = objDB.executeQuery(CommandType.Text, sql);
                return i;
            }else{
                return 0;
            }
        }

    }
}
