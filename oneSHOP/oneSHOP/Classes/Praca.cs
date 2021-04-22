using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oneSHOP.Classes
{
    class Praca
    {
        public int ID { get; set; }
        string Nome { get; set; }

        //Método de inclusão
        public async ValueTask<string> IncluirPraca(Praca praca)
        {
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            string comando = string.Format("EXECUTE InserirPraca '{0}'", praca.Nome);
            SqlCommand cmd = new SqlCommand(comando, sqlConn);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                sqlConn.Close();
                return "Sucesso";
            }
            else
            {
                sqlConn.Close();
                return "Falha";
            }
        }

        //Métodos de busca
        public async Task<SqlDataAdapter> BuscarPraca()
        {
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            SqlCommand cmd = new SqlCommand("EXECUTE BuscaPraca", sqlConn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            return adapter;
        }
        public async Task<SqlDataAdapter> BuscarPraca(int ID)
        {
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            string comando = string.Format("EXECUTE BuscaPracaID {0}", ID.ToString());
            SqlCommand cmd = new SqlCommand(comando, sqlConn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            return adapter;
        }

        //Método de atualização
        public async ValueTask<string> AtualizarPraca(Praca praca)
        {
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            string comando = string.Format("EXECUTE AtualizarPraca {0}, '{1}'", praca.ID.ToString(), praca.Nome);
            SqlCommand cmd = new SqlCommand(comando, sqlConn);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                sqlConn.Close();
                return "Sucesso";
            }
            else
            {
                sqlConn.Close();
                return "Falha";
            }
        }

        //Método de exclusão
        public async ValueTask<string> DeletarPraca(int ID)
        {
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            string comando = string.Format("EXECUTE DeletarPracaID '{0}'", ID.ToString());
            SqlCommand cmd = new SqlCommand(comando, sqlConn);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                sqlConn.Close();
                return "Sucesso";
            }
            else
            {
                sqlConn.Close();
                return "Falha";
            }
        }
    }
}
