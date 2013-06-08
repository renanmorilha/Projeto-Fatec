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
    public class PessoaFisicaModel
    {
        PessoaFisicaEntity pf;

        public PessoaFisicaModel(PessoaFisicaEntity p) {
            pf = p;
        }

        public PessoaFisicaModel()
        {
         
        }

        public long gravaPesFis(){

            if (pf.id == 0){
                return 0;
            }

            if (pf.nome == "" || pf.nome == null)
            {
                return 0;
            }

            if (pf.rg == "" || pf.rg == null)
            {
                return 0;
            }

            if (pf.status == "" || pf.status == null || pf.status.ToLower() != "ativo" || pf.status.ToLower() != "inativo")
            {
                return 0;
            }

            if (pf.cpf == "" || pf.cpf == null)
            {
                return 0;
            }

            if (pf.datanasc == null)
            {
                return 0;
            }

            PessoaFisicaData pd = new PessoaFisicaData(pf);
            long i;
            i = pd.gravaPessoaFisica();
            return i;

        }

        public SqlDataReader consultaPesFis(string cn, string nome, string status){
            if (nome == ""){
                return null;
            }

            if (status == "")
            {
                return null;
            }

            SqlDataReader wtbpesfis;
            PessoaFisicaData pd = new PessoaFisicaData();
            wtbpesfis = pd.consultaPessoaFisica(cn, nome, status);

            if (wtbpesfis != null && wtbpesfis.HasRows){
                return wtbpesfis;
            }else{
                return null;
            }

        }

        public PessoaFisicaEntity carregaPesFis(string cn, int id) {
            PessoaFisicaData pd = new PessoaFisicaData(pf);
            pf = pd.carregaPesFis(cn,id);
            return pf;
        }

        public long alterandoPesFis() {
            if (pf.id == 0)
            {
                return 0;
            }

            if (pf.nome == "" || pf.nome == null)
            {
                return 0;
            }

            if (pf.rg == "" || pf.rg == null)
            {
                return 0;
            }

            if (pf.status == "" || pf.status == null || pf.status.ToLower() != "ativo" || pf.status.ToLower() != "inativo")
            {
                return 0;
            }

            if (pf.cpf == "" || pf.cpf == null)
            {
                return 0;
            }

            if (pf.datanasc == null)
            {
                return 0;
            }

            long i;
            PessoaFisicaData pd = new PessoaFisicaData(pf);
            i = pd.alterandoPesFis();
            return i;

        }

    }
}
