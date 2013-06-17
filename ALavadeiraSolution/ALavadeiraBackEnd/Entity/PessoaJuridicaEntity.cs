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
    public class PessoaJuridicaEntity : PessoaEntity
    {
        public string cnpj;
        public string ie;
        public string razsoc;
        public string nomefant;

        public PessoaJuridicaEntity(string cn, int i, string cpj, string insc, string razaos, string nf, string st, string endereco, string bairro, string numero, string cep, int ddd, string telefone) : base(i, cn, st, endereco, bairro, numero, cep, ddd, telefone) {
            cnpj = cpj;
            ie = insc;
            razsoc = razaos;
            nomefant = nf;
        }

        public PessoaJuridicaEntity()
            : base()
        {
        }

        public PessoaJuridicaEntity(string cn, string cpj, string insc, string razaos, string nf, string st, string endereco, string bairro, string numero, string cep, int ddd, string telefone)
            : base(cn, st, endereco, bairro, numero, cep, ddd, telefone)
        {
            cnpj = cpj;
            ie = insc;
            razsoc = razaos;
            nomefant = nf;
        }

        public long gravaPesJur()
        {
            SqlDataReader wtbpj;
            wtbpj = this.gravaPessoa(this.conn);


            if (wtbpj != null && wtbpj.HasRows)
            {
                wtbpj.Read();
                this.id = Convert.ToInt32(wtbpj["nextcode"]);
                long i;
                PessoaJuridicaModel pm = new PessoaJuridicaModel(this);
                i = pm.gravaPesJur();
                return i;
            }
            else
            {
                return 0;
            }

        }

        public SqlDataReader consultaPesJur(string cn, string campo, string busca)
        {
            SqlDataReader wtbpesjur;
            PessoaJuridicaModel pm = new PessoaJuridicaModel();
            wtbpesjur = pm.consultaPesJur(cn, campo, busca);
            return wtbpesjur;
        }

        public long alterandoPesJur()
        {
            PessoaJuridicaModel pm = new PessoaJuridicaModel(this);
            long i;
            i = pm.alterandoPesJur();
            return i;
        }

        public void carregaPesJur(string cn, int id) {
            PessoaJuridicaModel pm = new PessoaJuridicaModel(this);
            PessoaJuridicaEntity pp = new PessoaJuridicaEntity();
            pp = pm.carregaPesJur(cn,id);
            this.nomefant = pp.nomefant;
            this.numero = pp.numero;
            this.ie = pp.ie;
            this.status = pp.status;
            this.telefone = pp.telefone;
            this.bairro = pp.bairro;
            this.cep = pp.cep;
            this.cnpj = pp.cnpj;
            this.razsoc = pp.razsoc;
            this.ddd = pp.ddd;
            this.endereco = pp.endereco;
        }

    }
}
