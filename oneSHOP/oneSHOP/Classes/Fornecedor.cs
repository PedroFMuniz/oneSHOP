using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oneSHOP.Classes
{
    class Fornecedor
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public Nullable<int> ID_Usuario { get; set; }

        //Método de inclusão
        public async ValueTask<string> IncluirFornecedor(Fornecedor fornecedor)
        {
            string CNPJ = "";
            string Endereco = "";
            string Telefone = "";
            string ID_Usuario = "";
            if (fornecedor.CNPJ != null)
            {
                CNPJ = "'" + fornecedor.CNPJ.ToString() + "'";
            }
            else
            {
                CNPJ = "NULL";
            }
            if (fornecedor.Endereco != null)
            {
                Endereco = "'" + fornecedor.Endereco.ToString() + "'";
            }
            else
            {
                Endereco = "NULL";
            }
            if (fornecedor.Telefone != null)
            {
                Telefone = "'" + fornecedor.Telefone.ToString() + "'";
            }
            else
            {
                Telefone = "NULL";
            }
            if (fornecedor.ID_Usuario != null)
            {
                ID_Usuario = fornecedor.ID_Usuario.ToString();
            }
            else
            {
                ID_Usuario = "NULL";
            }
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            string comando = string.Format("EXECUTE InserirFornecedor '{0}', {1}, {2}, {3}, {4}", fornecedor.Nome, CNPJ, Endereco, Telefone, ID_Usuario);
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
        public async Task<SqlDataAdapter> BuscarFornecedor()
        {
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            SqlCommand cmd = new SqlCommand("EXECUTE BuscaFornecedor", sqlConn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            return adapter;
        }
        public async Task<SqlDataAdapter> BuscarFornecedor(int ID)
        {
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            string comando = string.Format("EXECUTE BuscaFornecedorID '{0}'", ID.ToString());
            SqlCommand cmd = new SqlCommand(comando, sqlConn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            return adapter;
        }

        //Método de atualização
        public async ValueTask<string> AtualizarFornecedor(Fornecedor fornecedor)
        {
            string CNPJ = "";
            string Endereco = "";
            string Telefone = "";
            string ID_Usuario = "";
            if (fornecedor.CNPJ != null)
            {
                CNPJ = "'" + fornecedor.CNPJ.ToString() + "'";
            }
            else
            {
                CNPJ = "NULL";
            }
            if (fornecedor.Endereco != null)
            {
                Endereco = "'" + fornecedor.Endereco.ToString() + "'";
            }
            else
            {
                Endereco = "NULL";
            }
            if (fornecedor.Telefone != null)
            {
                Telefone = "'" + fornecedor.Telefone.ToString() + "'";
            }
            else
            {
                Telefone = "NULL";
            }
            if (fornecedor.ID_Usuario != null)
            {
                ID_Usuario = fornecedor.ID_Usuario.ToString();
            }
            else
            {
                ID_Usuario = "NULL";
            }
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            string comando = string.Format("EXECUTE AtualizarFornecedor {0}, '{1}', {2}, {3}, {4}, {5}", fornecedor.ID.ToString(), fornecedor.Nome, CNPJ, Endereco, Telefone, ID_Usuario);
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
        public async ValueTask<string> DeletarFornecedor(int ID)
        {
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            string comando = string.Format("EXECUTE DeletarFornecedorID '{0}'", ID.ToString());
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
