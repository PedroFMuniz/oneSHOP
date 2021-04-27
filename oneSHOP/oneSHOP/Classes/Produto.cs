using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oneSHOP.Classes
{
    class Produto
    {
		public int ID { get; set; }
		public string Nome { get; set; }
		public string Referencia { get; set; }
		public float Preco_Custo { get; set; }
		public float Preco_Venda { get; set; }
		public string Codigo { get; set; }
		public string Tipo_Codigo { get; set; }
		public Nullable<int> ID_Fiscal { get; set; }
		public Nullable<int> ID_Usuario { get; set; }
		public Nullable<int> ID_Grupo { get; set; }
		public string Foto { get; set; }
		public Nullable<int> Qt_Estoque { get; set; }
		public Nullable<int> Qt_Rua { get; set; }
		public string Inf_Adicionais { get; set; }
		public Nullable<int> ID_Tamanho { get; set; }
		public Nullable<int> ID_Linha { get; set; }
		public Nullable<int> ID_Fornecedor { get; set; }

        //Método de inclusão
        public async ValueTask<string> IncluirProduto(Produto produto)
        {
            string ID_Fiscal, ID_Usuario, ID_Grupo, Foto, Qt_Estoque, Qt_Rua, Inf_Adicionais, ID_Tamanho, ID_Linha, ID_Fornecedor;
            if(produto.ID_Fiscal != null)
            {
                ID_Fiscal = produto.ID_Fiscal.ToString();
            }
            else
            {
                ID_Fiscal = "NULL";
            }
            if(produto.ID_Usuario != null)
            {
                ID_Usuario = produto.ID_Usuario.ToString();
            }
            else
            {
                ID_Usuario = "NULL";
            }
            if(produto.ID_Grupo != null)
            {
                ID_Grupo = produto.ID_Grupo.ToString();
            }
            else
            {
                ID_Grupo = "NULL";
            }
            if(produto.Foto != null)
            {
                Foto = "'" + produto.Foto.ToString() + "'";
            }
            else
            {
               Foto = "NULL";
            }
            if(produto.Qt_Estoque != null)
            {
                Qt_Estoque = produto.Qt_Estoque.ToString();
            }
            else
            {
                Qt_Estoque = "NULL";
            }
            if(produto.Qt_Rua != null)
            {
                Qt_Rua = produto.Qt_Rua.ToString();
            }
            else
            {
                Qt_Rua = "NULL";
            }
            if(produto.Inf_Adicionais != null)
            {
                Inf_Adicionais = "'" + produto.Inf_Adicionais.ToString() + "'";
            }
            else
            {
                Inf_Adicionais = "NULL";
            }
            if(produto.ID_Tamanho != null)
            {
                ID_Tamanho = produto.ID_Tamanho.ToString();
            }
            else
            {
                ID_Tamanho = "NULL";
            }
            if(produto.ID_Linha != null)
            {
                ID_Linha = produto.ID_Linha.ToString();
            }
            else
            {
                ID_Linha = "NULL";
            }
            if(produto.ID_Fornecedor != null)
            {
                ID_Fornecedor = produto.ID_Fornecedor.ToString();
            }
            else
            {
                ID_Fornecedor = "NULL";
            }
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            string comando = string.Format("EXECUTE InserirProduto '{0}', '{1}', {2}, {3}, '{4}', '{5}', {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14}, {15}",produto.Nome, produto.Referencia, produto.Preco_Custo.ToString().Replace(",","."), produto.Preco_Venda.ToString().Replace(",", "."), produto.Codigo, produto.Tipo_Codigo, ID_Fiscal,ID_Usuario, ID_Grupo, Foto, Qt_Estoque, Qt_Rua, Inf_Adicionais, ID_Tamanho, ID_Linha, ID_Fornecedor);
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
        public async Task<SqlDataAdapter> BuscarProduto()
        {
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            SqlCommand cmd = new SqlCommand("EXECUTE BuscaProduto", sqlConn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            return adapter;
        }
        public async Task<SqlDataAdapter> BuscarProduto(int ID)
        {
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            string comando = string.Format("EXECUTE BuscaProdutoID {0}", ID.ToString());
            SqlCommand cmd = new SqlCommand(comando, sqlConn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            return adapter;
        }
        public async Task<SqlDataAdapter> BuscarProduto(string nome)
        {
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            string comando = string.Format("EXECUTE BuscaProdutoNome '{0}'", nome);
            SqlCommand cmd = new SqlCommand(comando, sqlConn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            return adapter;
        }
        public async Task<SqlDataAdapter> BuscarProduto2(string codigo)
        {
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            string comando = string.Format("EXECUTE BuscaProdutoCodigo '{0}'", codigo);
            SqlCommand cmd = new SqlCommand(comando, sqlConn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            return adapter;
        }

        //Método de atualização
        public async ValueTask<string> AtualizarProduto(Produto produto)
        {
            string ID_Fiscal, ID_Usuario, ID_Grupo, Foto, Qt_Estoque, Qt_Rua, Inf_Adicionais, ID_Tamanho, ID_Linha, ID_Fornecedor;
            if (produto.ID_Fiscal != null)
            {
                ID_Fiscal = produto.ID_Fiscal.ToString();
            }
            else
            {
                ID_Fiscal = "NULL";
            }
            if (produto.ID_Usuario != null)
            {
                ID_Usuario = produto.ID_Usuario.ToString();
            }
            else
            {
                ID_Usuario = "NULL";
            }
            if (produto.ID_Grupo != null)
            {
                ID_Grupo = produto.ID_Grupo.ToString();
            }
            else
            {
                ID_Grupo = "NULL";
            }
            if (produto.Foto != null)
            {
                Foto = "'" + produto.Foto.ToString() + "'";
            }
            else
            {
                Foto = "NULL";
            }
            if (produto.Qt_Estoque != null)
            {
                Qt_Estoque = produto.Qt_Estoque.ToString();
            }
            else
            {
                Qt_Estoque = "NULL";
            }
            if (produto.Qt_Rua != null)
            {
                Qt_Rua = produto.Qt_Rua.ToString();
            }
            else
            {
                Qt_Rua = "NULL";
            }
            if (produto.Inf_Adicionais != null)
            {
                Inf_Adicionais = "'" + produto.Inf_Adicionais.ToString() + "'";
            }
            else
            {
                Inf_Adicionais = "NULL";
            }
            if (produto.ID_Tamanho != null)
            {
                ID_Tamanho = produto.ID_Tamanho.ToString();
            }
            else
            {
                ID_Tamanho = "NULL";
            }
            if (produto.ID_Linha != null)
            {
                ID_Linha = produto.ID_Linha.ToString();
            }
            else
            {
                ID_Linha = "NULL";
            }
            if (produto.ID_Fornecedor != null)
            {
                ID_Fornecedor = produto.ID_Fornecedor.ToString();
            }
            else
            {
                ID_Fornecedor = "NULL";
            }
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            string comando = string.Format("EXECUTE AtualizarProduto {0}, '{1}', '{2}', {3}, {4}, '{5}', '{6}', {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14}, {15}, {16}", produto.ID.ToString(),produto.Nome, produto.Referencia, produto.Preco_Custo.ToString().Replace(",", "."), produto.Preco_Venda.ToString().Replace(",", "."), produto.Codigo, produto.Tipo_Codigo, ID_Fiscal, ID_Usuario, ID_Grupo, Foto, Qt_Estoque, Qt_Rua, Inf_Adicionais, ID_Tamanho, ID_Linha, ID_Fornecedor);
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
        public async ValueTask<string> DeletarProduto(int ID)
        {
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            string comando = string.Format("EXECUTE DeletarProdutoID '{0}'", ID.ToString());
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
