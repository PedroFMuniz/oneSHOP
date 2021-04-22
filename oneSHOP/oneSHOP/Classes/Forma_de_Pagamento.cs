using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oneSHOP.Classes
{
    class Forma_de_Pagamento
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public float Taxa1 { get; set; }
        public float Taxa2 { get; set; }
        public float Taxa3 { get; set; }
        public float Taxa4 { get; set; }
        public float Taxa5 { get; set; }
        public float Taxa6 { get; set; }
        public float Taxa7 { get; set; }
        public float Taxa8 { get; set; }
        public float Taxa9 { get; set; }
        public float Taxa10 { get; set; }
        public float Taxa11 { get; set; }
        public float Taxa12 { get; set; }

        //Método de inclusão
        public async ValueTask<string> IncluirForma_de_Pagamento(Forma_de_Pagamento forma_de_pagamento)
        {
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            string comando = string.Format("EXECUTE InserirForma_de_Pagamento '{0}', {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}", forma_de_pagamento.Nome, forma_de_pagamento.Taxa1.ToString(), forma_de_pagamento.Taxa2.ToString(), forma_de_pagamento.Taxa3.ToString(), forma_de_pagamento.Taxa4.ToString(), forma_de_pagamento.Taxa5.ToString(), forma_de_pagamento.Taxa6.ToString(), forma_de_pagamento.Taxa7.ToString(), forma_de_pagamento.Taxa8.ToString(), forma_de_pagamento.Taxa9.ToString(), forma_de_pagamento.Taxa10.ToString(), forma_de_pagamento.Taxa11.ToString(), forma_de_pagamento.Taxa12.ToString());
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
        public async Task<SqlDataAdapter> BuscarForma_de_Pagamento()
        {
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            SqlCommand cmd = new SqlCommand("EXECUTE BuscaForma_de_Pagamento", sqlConn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            return adapter;
        }
        public async Task<SqlDataAdapter> BuscarForma_de_Pagamento(int ID)
        {
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            string comando = string.Format("EXECUTE BuscaForma_de_PagamentoID {0}", ID.ToString());
            SqlCommand cmd = new SqlCommand(comando, sqlConn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            return adapter;
        }

        //Método de atualização
        public async ValueTask<string> AtualizarForma_de_Pagamento(Forma_de_Pagamento forma_de_pagamento)
        {
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            string comando = string.Format("EXECUTE AtualizarForma_de_Pagamento {0}, '{1}', {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}", forma_de_pagamento.ID.ToString(), forma_de_pagamento.Nome, forma_de_pagamento.Taxa1.ToString(), forma_de_pagamento.Taxa2.ToString(), forma_de_pagamento.Taxa3.ToString(), forma_de_pagamento.Taxa4.ToString(), forma_de_pagamento.Taxa5.ToString(), forma_de_pagamento.Taxa6.ToString(), forma_de_pagamento.Taxa7.ToString(), forma_de_pagamento.Taxa8.ToString(), forma_de_pagamento.Taxa9.ToString(), forma_de_pagamento.Taxa10.ToString(), forma_de_pagamento.Taxa11.ToString(), forma_de_pagamento.Taxa12.ToString(), forma_de_pagamento.ID.ToString(), forma_de_pagamento.Nome);
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
        public async ValueTask<string> DeletarForma_de_Pagamento(int ID)
        {
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            string comando = string.Format("EXECUTE DeletarForma_de_PagamentoID '{0}'", ID.ToString());
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
