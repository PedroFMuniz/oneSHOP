using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace oneSHOP.Classes
{
    class Empresa
    {
        //Declaração de variáveis
        public int ID { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public int CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public Nullable<int> ID_Usuario { get; set; }

        //Método para incluir registro no BD
        public async ValueTask<string> IncluirEmpresa(Empresa empresa)
        {
            string ID_Usuario = "";
            if (empresa.ID_Usuario != null)
            {
                ID_Usuario = empresa.ID_Usuario.ToString();
            }
            else
            {
                ID_Usuario = "NULL";
            }
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  "+ ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            string comando = string.Format("EXECUTE InserirEmpresa '{0}', '{1}', '{2}', '{3}', '{4}', {5}, '{6}', '{7}', {8}", empresa.Nome, empresa.CNPJ, empresa.Endereco, empresa.Numero, empresa.Bairro, empresa.CEP.ToString(), empresa.Cidade, empresa.Estado, ID_Usuario);
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
        public async Task<SqlDataAdapter> BuscarEmpresa()
        {
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            SqlCommand cmd = new SqlCommand("EXECUTE BuscaEmpresa", sqlConn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            return adapter;
        }
        public async Task<SqlDataAdapter> BuscarEmpresa(int ID)
        {
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            string comando = string.Format("EXECUTE BuscaEmpresaID {0}", ID.ToString());
            SqlCommand cmd = new SqlCommand(comando, sqlConn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            return adapter;
        }
        //Método de atualização
        public async ValueTask<string> AtualizarEmpresa(Empresa empresa)
        {
            string ID_Usuario = "";
            if (empresa.ID_Usuario != null)
            {
                ID_Usuario = empresa.ID_Usuario.ToString();
            }
            else
            {
                ID_Usuario = "NULL";
            }
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            string comando = string.Format("EXECUTE AtualizarEmpresa {0}, '{1}', '{2}', '{3}', '{4}', '{5}', {6}, '{7}', '{8}', {9}", empresa.ID.ToString(), empresa.Nome, empresa.CNPJ, empresa.Endereco, empresa.Numero, empresa.Bairro, empresa.CEP.ToString(), empresa.Cidade, empresa.Estado, ID_Usuario);
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
        public async ValueTask<string> DeletarEmpresa(int ID)
        {
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            string comando = string.Format("EXECUTE DeletarEmpresaID '{0}'", ID.ToString());
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
