using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oneSHOP.Classes
{
    class Movimento
    {
        public int ID { get; set; }
        public float Valor_Bruto { get; set; }
        public float Valor_Liquido { get; set; }
        public DateTime Data_de_Emissao { get; set; }
        public string Tipo { get; set; }
        public Nullable<int> ID_Usuario { get; set; }
        public Nullable<int> ID_Pessoa { get; set; }

        public async ValueTask<string> IncluirMovimento(Movimento movimento)
        {
            string ID_Usuario, ID_Pessoa;
            if(movimento.ID_Usuario != null)
            {
                ID_Usuario = movimento.ID_Usuario.ToString();
            }
            else
            {
                ID_Usuario = "NULL";
            }
            if(movimento.ID_Pessoa != null)
            {
                ID_Pessoa = movimento.ID_Pessoa.ToString();
            }
            else
            {
                ID_Pessoa = "NULL";
            }
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            string comando = string.Format("EXECUTE InserirMovimento {0}, {1}, '{2}', {3}, {4}, {5}", movimento.Valor_Bruto.ToString().Replace(",", "."), movimento.Valor_Liquido.ToString().Replace(",", "."),movimento.Data_de_Emissao.ToString("yyyyMMdd"), movimento.Tipo, ID_Usuario, ID_Pessoa);
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
        public async Task<SqlDataAdapter> BuscarMovimento()
        {
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            SqlCommand cmd = new SqlCommand("EXECUTE BuscaMovimento", sqlConn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            return adapter;
        }
        public async Task<SqlDataAdapter> BuscarMovimento(int ID)
        {
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            string comando = string.Format("EXECUTE BuscaMovimentoID '{0}'", ID.ToString());
            SqlCommand cmd = new SqlCommand(comando, sqlConn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            return adapter;
        }

        //Método de atualização
        public async ValueTask<string> AtualizarMovimento(Movimento movimento)
        {
            string ID_Usuario, ID_Pessoa;
            if (movimento.ID_Usuario != null)
            {
                ID_Usuario = movimento.ID_Usuario.ToString();
            }
            else
            {
                ID_Usuario = "NULL";
            }
            if (movimento.ID_Pessoa != null)
            {
                ID_Pessoa = movimento.ID_Pessoa.ToString();
            }
            else
            {
                ID_Pessoa = "NULL";
            }
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            string comando = string.Format("EXECUTE AtualizarMovimento {0}, {1}, {2}, '{3}', '{4}', {5}, {6}", movimento.ID.ToString(), movimento.Valor_Bruto.ToString().Replace(",", "."), movimento.Valor_Liquido.ToString().Replace(",", "."), movimento.Data_de_Emissao.ToString("yyyyMMdd"), movimento.Tipo, ID_Usuario, ID_Pessoa);
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
        public async ValueTask<string> DeletarMovimento(int ID)
        {
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            string comando = string.Format("EXECUTE DeletarMovimentoID '{0}'", ID.ToString());
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
