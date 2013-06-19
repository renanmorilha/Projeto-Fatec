using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ALavadeiraBackEnd.Data;
using ALavadeiraBackEnd.Entity;
using System.Data;
using System.Data.SqlClient;

namespace ALavadeiraBackEnd.Model
{
    public class PessoaModel
    {
        private PessoaEntity pm;

        public PessoaModel(PessoaEntity pe) {
            pm = pe;
        }

        public SqlDataReader gravaPessoa() {
            if (pm.bairro != "" && pm.cep != "" && pm.ddd != 0 && pm.endereco != "" && pm.status != "" && pm.numero != "" && pm.telefone != "")
            {
                PessoaData pd = new PessoaData(pm);
                SqlDataReader wtbpm;
                wtbpm = pd.gravaPessoa();
                if (wtbpm.HasRows && wtbpm != null)
                {
                    return wtbpm;
                }
                else
                {
                    return null;
                }
            }
            else {
                return null;
            }
        }

        public long alterandoPessoa(){
            //if (pm.bairro != "" && pm.cep != "" && pm.ddd != 0 && pm.endereco != "" && pm.status != "" && pm.numero != "" && pm.telefone != "")
            //{
                long i;
                PessoaData pd = new PessoaData(pm);
                i = pd.alterandoPessoa();
                return i;
            //}
            //else {
            //    return 0;
            //}
        }

    }
}
