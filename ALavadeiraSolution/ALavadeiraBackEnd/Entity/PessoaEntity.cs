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
    abstract public class PessoaEntity
    {
        public string status;
        public string endereco;
        public string bairro;
        public string numero;
        public string cep;
        public int ddd;
        public string telefone;
        public int id;
        public string conn;

        public PessoaEntity(string cn, string st, string en, string bair, string num, string c, int d, string tel)
        {
            status = st;
            endereco = en;
            bairro = bair;
            numero = num;
            cep = c;
            ddd = d;
            telefone = tel;
            conn = cn;
        }

        public PessoaEntity(int idd, string cn, string st, string en, string bair, string num, string c, int d, string tel)
        {
            id = idd;
            status = st;
            endereco = en;
            bairro = bair;
            numero = num;
            cep = c;
            ddd = d;
            telefone = tel;
            conn = cn;
        }

        public PessoaEntity() { }

        public SqlDataReader gravaPessoa(string cn)
        {
            SqlDataReader wtbpes;

            PessoaModel pm = new PessoaModel(this);
            wtbpes = pm.gravaPessoa();
            if (wtbpes.HasRows)
            {
                return wtbpes;
            }
            else {
                return null;
            }
        }

        public long alterandoPessoa() {
            PessoaModel pm = new PessoaModel(this);
            long i;
            i = pm.alterandoPessoa();
            return i;
        }

    }
}
