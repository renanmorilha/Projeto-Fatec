using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ALavadeiraBackEnd.Model;


namespace ALavadeiraBackEnd.Entity
{
    public class PessoaFisicaEntity : PessoaEntity
    {

        public string cpf;
        public string nome;
        public string rg;
        public DateTime datanasc;

        public PessoaFisicaEntity(string cn, int i, string cp, string n, string r, DateTime dn, string st, string endereco, string bairro, string numero, string cep, int ddd, string telefone)
            : base(i, cn, st, endereco, bairro, numero, cep, ddd, telefone)
        {
            cpf = cp;
            nome = n;
            rg = r;
            datanasc = dn;
        }

        public PessoaFisicaEntity(string cn, string cp, string n, string r, DateTime dn, string st, string endereco, string bairro, string numero, string cep, int ddd, string telefone)
            : base(cn, st, endereco, bairro, numero, cep, ddd, telefone)
        {
            cpf = cp;
            nome = n;
            rg = r;
            datanasc = dn;
        }

        public PessoaFisicaEntity() : base() { 
        }

        public long gravaPesFis(){
            SqlDataReader wtbpf;
            wtbpf = this.gravaPessoa(this.conn);
            

            if (wtbpf != null && wtbpf.HasRows)
            {
                wtbpf.Read();
                this.id = Convert.ToInt32(wtbpf["nextcode"]);
                long i;
                PessoaFisicaModel pm = new PessoaFisicaModel(this);
                i = pm.gravaPesFis();
                return i;
            }
            else {
                return 0;
            }
    
        }

        public SqlDataReader consultaPesFis(string cn, string campo, string busca) {
            SqlDataReader wtbpesfis;
            PessoaFisicaModel pm = new PessoaFisicaModel();
            wtbpesfis = pm.consultaPesFis(cn, campo, busca);
            return wtbpesfis;
        }

        public long alterandoPesFis()
        {
            PessoaFisicaModel pm = new PessoaFisicaModel(this);
            long i;
            i = pm.alterandoPesFis();
            return i;
        }

        public void carregaPesFis(string cn, int id)
        {
            PessoaFisicaModel pm = new PessoaFisicaModel(this);
            PessoaFisicaEntity pp = new PessoaFisicaEntity();
            pp = pm.carregaPesFis(cn, id);
            this.nome = pp.nome;
            this.numero = pp.numero;
            this.rg = pp.rg;
            this.status = pp.status;
            this.telefone = pp.telefone;
            this.bairro = pp.bairro;
            this.cep = pp.cep;
            this.cpf = pp.cpf;
            this.datanasc = pp.datanasc;
            this.ddd = pp.ddd;
            this.endereco = pp.endereco;
        }

    }
}
