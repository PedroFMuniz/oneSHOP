using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oneSHOP.Classes
{
    class Fiscal
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string ncm { get; set; }
        public string unidade { get; set; }
        public int origem { get; set; }
        public string classe_imposto { get; set; }
        public Nullable<int> ID_Usuario { get; set; }

    //Método de inclusão
    public async ValueTask<string> IncluirFiscal(Fiscal fiscal)
        {
            string ID_Usuario = "";
            if (fiscal.ID_Usuario != null)
            {
                ID_Usuario = fiscal.ID_Usuario.ToString();
            }
            else
            {
                ID_Usuario = "NULL";
            }
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            string comando = string.Format("EXECUTE InserirFiscal '{0}', '{1}', '{2}', {3}, '{4}', {5}", fiscal.Nome, fiscal.ncm, fiscal.unidade, fiscal.origem.ToString(), fiscal.classe_imposto, ID_Usuario);
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
        public async Task<SqlDataAdapter> BuscarFiscal()
        {
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            SqlCommand cmd = new SqlCommand("EXECUTE BuscaFiscal", sqlConn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            return adapter;
        }
        public async Task<SqlDataAdapter> BuscarFiscal(int ID)
        {
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            string comando = string.Format("EXECUTE BuscaFiscalID {0}", ID.ToString());
            SqlCommand cmd = new SqlCommand(comando, sqlConn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            return adapter;
        }

        //Método de atualização
        public async ValueTask<string> AtualizarFiscal(Fiscal fiscal)
        {
            string ID_Usuario = "";
            if (fiscal.ID_Usuario != null)
            {
                ID_Usuario = fiscal.ID_Usuario.ToString();
            }
            else
            {
                ID_Usuario = "NULL";
            }
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            string comando = string.Format("EXECUTE AtualizarFiscal {0}, '{1}', '{2}', '{3}', {4}, '{5}', {6}", fiscal.ID.ToString(), fiscal.Nome, fiscal.ncm, fiscal.unidade, fiscal.origem.ToString(), fiscal.classe_imposto, ID_Usuario);
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
        public async ValueTask<string> DeletarFiscal(int ID)
        {
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            string comando = string.Format("EXECUTE DeletarFiscalID '{0}'", ID.ToString());
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
