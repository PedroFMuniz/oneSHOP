using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oneSHOP.Classes
{
    class Grupo
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public Nullable<int> Estoque_min { get; set; }
        public Nullable<int> Estoque_max { get; set; }

        //Método de inclusão
        public async ValueTask<string> IncluirGrupo(Grupo grupo)
        {
            string Estoque_max = "";
            string Estoque_min = "";
            if (grupo.Estoque_max != null)
            {
                Estoque_max = "'" + grupo.Estoque_max.ToString() + "'";
            }
            else
            {
                Estoque_max = "NULL";
            }
            if (grupo.Estoque_min != null)
            {
                Estoque_min = "'" + grupo.Estoque_min.ToString() + "'";
            }
            else
            {
                Estoque_min = "NULL";
            } 
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            string comando = string.Format("EXECUTE InserirGrupo '{0}', {1}, {2}", grupo.Nome, Estoque_min, Estoque_max);
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
        public async Task<SqlDataAdapter> BuscarGrupo()
        {
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            SqlCommand cmd = new SqlCommand("EXECUTE BuscaGrupo", sqlConn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            return adapter;
        }
        public async Task<SqlDataAdapter> BuscarGrupo(int ID)
        {
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            string comando = string.Format("EXECUTE BuscaGrupoID '{0}'", ID.ToString());
            SqlCommand cmd = new SqlCommand(comando, sqlConn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            return adapter;
        }

        //Método de atualização
        public async ValueTask<string> AtualizarGrupo(Grupo grupo)
        {
            string Estoque_max = "";
            string Estoque_min = "";
            if (grupo.Estoque_max != null)
            {
                Estoque_max = "'" + grupo.Estoque_max.ToString() + "'";
            }
            else
            {
                Estoque_max = "NULL";
            }
            if (grupo.Estoque_min != null)
            {
                Estoque_min = "'" + grupo.Estoque_min.ToString() + "'";
            }
            else
            {
                Estoque_min = "NULL";
            }
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            string comando = string.Format("EXECUTE AtualizarGrupo {0}, '{1}', {2}, {3}", grupo.ID.ToString(), grupo.Nome, Estoque_min, Estoque_max);
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
        public async ValueTask<string> DeletarGrupo(int ID)
        {
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            string comando = string.Format("EXECUTE DeletarGrupoID '{0}'", ID.ToString());
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
