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
    class PessoaJuridicaData
    {
           PessoaJuridicaEntity pj;
        

        public PessoaJuridicaData(PessoaJuridicaEntity p) {
            pj = p;
        }
        public PessoaJuridicaData()
        {
            
        }

        public long gravaPessoaJuridica() {
            DB objDB = new DB(pj.conn);
            string sql = "INSERT INTO Pes_Juridica values ("+pj.id+", '"+pj.cnpj+"', '"+pj.razsoc+"', '"+pj.ie+"', '"+pj.nomefant+"')";
            long i;
            i = objDB.executeQuery(CommandType.Text, sql);
            return i;
        }

        public SqlDataReader consultaPessoaJuridica(string cn, string nomef, string status) {
            SqlDataReader wtbpesjur;
            DB objDB = new DB(cn);
            string sql = "";
            sql = "SELECT pj.*, p.* FROM pessoas p INNER JOIN Pes_Juridica pj ON p.id_pes = pj.id_pes WHERE pj.nome_fant like '"+nomef+"%' and p.status_pes like '"+status+"%' ";
            wtbpesjur = objDB.executeReader(CommandType.Text,sql);

            if (wtbpesjur != null || wtbpesjur.HasRows)
            {
                return wtbpesjur;
            }
            else {
                return null;
            }



        }

        public PessoaJuridicaEntity carregaPesJur (string cn, int id)
        {
            SqlDataReader wtbpesfis;
            DB objDB = new DB(cn);
            PessoaJuridicaEntity pj = new PessoaJuridicaEntity();
            string sql = "";
            sql = "SELECT pj.*, p.* FROM Pessoas p INNER JOIN Pes_Juridica pj ON p.id_pes = pj.id_pes where pj.id_pes like " + id;
            wtbpesfis = objDB.executeReader(CommandType.Text, sql);

            if (wtbpesfis.HasRows)
            {
                pj.bairro = Convert.ToString(wtbpesfis["bairro"]);
                pj.cep = Convert.ToString(wtbpesfis["cep"]);
                pj.cnpj = Convert.ToString(wtbpesfis["cnpj"]);
                pj.razsoc = Convert.ToString(wtbpesfis["razao_social"]);
                pj.ddd = Convert.ToInt32(wtbpesfis["ddd"]);
                pj.endereco = Convert.ToString(wtbpesfis["endereco"]);
                pj.id = Convert.ToInt32(wtbpesfis["pj.id_pes"]);
                pj.nomefant = Convert.ToString(wtbpesfis["nome_fant"]);
                pj.numero = Convert.ToString(wtbpesfis["numero"]);
                pj.ie = Convert.ToString(wtbpesfis["insc_estadual"]);
                pj.status = Convert.ToString(wtbpesfis["status_pes"]);
                pj.telefone = Convert.ToString(wtbpesfis["telefone"]);
                return pj;
            }
            else
            {
                return null;
            }
        }

        public long alterandoPesJur()
        {
            DB objDB = new DB(pj.conn);
            string sql = "";
            long i;
            long y;
            y = pj.alterandoPessoa();
            if (y == 1)
            {
                sql = "UPDATE Pes_Juridica set nome_fant = '" + pj.nomefant + "', cnpj = '" + pj.cnpj + "', razao_social = '" + pj.razsoc + "', insc_estadual = '" + pj.ie + "' where id_pes = '" + pj.id + "'";
                i = objDB.executeQuery(CommandType.Text, sql);
                return i;
            }
            else
            {
                return 0;
            }
        }

    }
}
