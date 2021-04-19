using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oneSHOP.Classes
{
    class Pedido
    {
        public int ID { get; set; }
        public float Valor { get; set; }
        public float Valor_de_Venda { get; set; }
        public float Valor_de_Comissao { get; set; }
        public float Valor_Recebimento { get; set; }
        public string _Status { get; set; }
        public Nullable<int> ID_Usuario { get; set; }
        public Nullable<int> ID_Pessoa { get; set; }
        public string Observacoes { get; set; }

        //Método de inclusão
        public async ValueTask<string> IncluirPedido(Pedido pedido)
        {
            string ID_Usuario, ID_Pessoa, Observacoes;
            if(pedido.ID_Usuario != null)
            {
                ID_Usuario = pedido.ID_Usuario.ToString();
            }
            else
            {
                ID_Usuario = "NULL";
            }
            if(pedido.ID_Pessoa != null)
            {
                ID_Pessoa = pedido.ID_Pessoa.ToString();
            }
            else
            {
                ID_Pessoa = "NULL";
            }
            if(pedido.Observacoes != null)
            {
                Observacoes = "'" + pedido.Observacoes.ToString() + "'";
            }
            else
            {
                Observacoes = "NULL";
            }
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            string comando = string.Format("EXECUTE InserirPedido {0}, {1}, {2}, {3}, '{4}', {5}, {6}, '{7}'",pedido.Valor.ToString().Replace(",", "."), pedido.Valor_de_Venda.ToString().Replace(",", "."), pedido.Valor_de_Comissao.ToString().Replace(",", "."), pedido.Valor_Recebimento.ToString().Replace(",", "."), pedido._Status, pedido.ID_Usuario.ToString(), pedido.ID_Pessoa.ToString(), pedido.Observacoes);
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
        public async Task<SqlDataAdapter> BuscarPedido()
        {
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            SqlCommand cmd = new SqlCommand("EXECUTE BuscaPedido", sqlConn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            return adapter;
        }
        public async Task<SqlDataAdapter> BuscarPedido(int ID)
        {
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            string comando = string.Format("EXECUTE BuscaPedidoID '{0}'", ID.ToString());
            SqlCommand cmd = new SqlCommand(comando, sqlConn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            return adapter;
        }

        //Método de atualização
        public async ValueTask<string> AtualizarPedido(Pedido pedido)
        {
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            string comando = string.Format("EXECUTE AtualizarPedido {0}, {1}, {2}, {3}, {4}, '{5}', {6}, {7}, '{8}'", pedido.ID.ToString(), pedido.Valor.ToString().Replace(",", "."), pedido.Valor_de_Venda.ToString().Replace(",", "."), pedido.Valor_de_Comissao.ToString().Replace(",", "."), pedido.Valor_Recebimento.ToString().Replace(",", "."), pedido._Status, pedido.ID_Usuario.ToString(), pedido.ID_Pessoa.ToString(), pedido.Observacoes);
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
        public async ValueTask<string> DeletarPedido(int ID)
        {
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            string comando = string.Format("EXECUTE DeletarPedidoID '{0}'", ID.ToString());
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
