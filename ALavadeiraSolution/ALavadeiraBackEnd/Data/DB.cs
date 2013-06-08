using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Data;

namespace ALavadeiraBackEnd.Data
{

    public class DB
    {
        private string connstr;

        public DB(string connr) {
            connstr = connr;
        }

        private SqlConnection conectarDB(long i)
        {
            SqlConnection con = new SqlConnection();
            if (i == 1){
                try
                {
                    
                    con.ConnectionString = connstr;
                    return con;
                }catch(SqlException ex){
                    return null;
                    throw;
                }
            }else{
                con.Close();
                return con;
            }
        }

        private long prepareCommand(SqlCommand cmd, CommandType cmdType, string cmdText) {

            SqlConnection cone;
            cone = conectarDB(1);
            if (cone != null)
            {
                if (cone.State != ConnectionState.Open)
                {
                    cone.Open();
                }
                cmd.Connection = cone;
                cmd.CommandText = cmdText;
                cmd.CommandType = cmdType;
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public SqlDataReader executeReader(CommandType cmdType, string cmdText)
        {
            long prep;
            SqlCommand cmd = new SqlCommand();
            prep = prepareCommand(cmd, cmdType, cmdText);

            if (prep != 0){
                try
                {
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    SqlConnection cn;
                    cn = conectarDB(0);
                    return dr;
                }catch(SqlException ex){
                    SqlConnection cn;
                    cn = conectarDB(0);
                    return null;
                    throw;
                }
            }else{
                return null;
            }
            
        }

        public long executeQuery(CommandType cmdType, string cmdText)
        {
            long prep;
            long value;
            SqlCommand cmd = new SqlCommand();
            prep = prepareCommand(cmd, cmdType, cmdText);

            if (prep != 0)
            {
                value = cmd.ExecuteNonQuery();
                SqlConnection cn;
                cn = conectarDB(0);
                return value;
            }
            else
            {
                SqlConnection cn;
                cn = conectarDB(0);
                return 0;
            }

        }






    }
}
