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
    public class PessoaJuridicaModel
    {
        PessoaJuridicaEntity pj;

        public PessoaJuridicaModel(PessoaJuridicaEntity p) {
            pj = p;
        }

        public PessoaJuridicaModel()
        {
        }

        public long gravaPesJur()
        {

            if (pj.id == 0)
            {
                return 0;
            }

            if (pj.nomefant == "" || pj.nomefant == null)
            {
                return 0;
            }

            if (pj.ie == "" || pj.ie == null)
            {
                return 0;
            }

            if (pj.status == "" || pj.status == null || pj.status.ToLower() != "ativo" || pj.status.ToLower() != "inativo")
            {
                return 0;
            }

            if (pj.cnpj == "" || pj.cnpj == null)
            {
                return 0;
            }

            if (pj.razsoc == "" || pj.razsoc == null)
            {
                return 0;
            }

            PessoaJuridicaData pd = new PessoaJuridicaData(pj);
            long i;
            i = pd.gravaPessoaJuridica();
            return i;

        }

        public SqlDataReader consultaPesJur(string cn, string nomef, string status)
        {
            if (nomef == "")
            {
                return null;
            }

            if (status == "")
            {
                return null;
            }

            SqlDataReader wtbpesjur;
            PessoaJuridicaData pd = new PessoaJuridicaData();
            wtbpesjur = pd.consultaPessoaJuridica(cn, nomef, status);

            if (wtbpesjur != null && wtbpesjur.HasRows)
            {
                return wtbpesjur;
            }
            else
            {
                return null;
            }

        }

        public PessoaJuridicaEntity carregaPesJur(string cn, int id)
        {
            PessoaJuridicaData pd = new PessoaJuridicaData(pj);
            pj = pd.carregaPesJur(cn, id);
            return pj;
        }

        public long alterandoPesJur(){

            if (pj.id == 0)
            {
                return 0;
            }

            if (pj.nomefant == "" || pj.nomefant == null)
            {
                return 0;
            }

            if (pj.ie == "" || pj.ie == null)
            {
                return 0;
            }

            if (pj.status == "" || pj.status == null || pj.status.ToLower() != "ativo" || pj.status.ToLower() != "inativo")
            {
                return 0;
            }

            if (pj.cnpj == "" || pj.cnpj == null)
            {
                return 0;
            }

            if (pj.razsoc == "" || pj.razsoc == null)
            {
                return 0;
            }

            long i;
            PessoaJuridicaData pd = new PessoaJuridicaData(pj);
            i = pd.alterandoPesJur();
            return i;
        }

    }
}
