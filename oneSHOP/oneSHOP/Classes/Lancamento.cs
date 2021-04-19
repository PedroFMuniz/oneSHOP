using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oneSHOP.Classes
{
    class Lancamento
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public float Valor { get; set; }
        public float Desconto_Comissao { get; set; }
        public DateTime Emissao { get; set; }
        public DateTime Vencimento { get; set; }
        public string _Status { get; set; }
        public int Venda { get; set; }
        public Nullable<int> ID_Usuario { get; set; }
        public Nullable<int> ID_Natureza { get; set; }
        public Nullable<int> ID_Conta { get; set; }
        public Nullable<int> ID_Forma_de_Pagamento { get; set; }
        public DateTime Baixa { get; set; }
        public string Descricao { get; set; }

        //Método de inclusão
        public async ValueTask<string> IncluirLancamento(Lancamento lancamento)
        {
            string ID_Usuario, ID_Natureza, ID_Conta, ID_Forma_de_Pagamento, Baixa, Descricao;
            if(lancamento.ID_Usuario != null)
            {
                ID_Usuario = lancamento.ID_Usuario.ToString();
            }
            else
            {
                ID_Usuario = "NULL";
            }
            if(lancamento.ID_Natureza != null)
            {
                ID_Natureza = lancamento.ID_Natureza.ToString();
            }
            else
            {
                ID_Natureza = "NULL";
            }
            if(lancamento.ID_Conta != null)
            {
                ID_Conta = lancamento.ID_Conta.ToString();
            }
            else
            {
                ID_Conta = "NULL";
            }
            if(lancamento.ID_Forma_de_Pagamento != null)
            {
                ID_Forma_de_Pagamento = lancamento.ID_Forma_de_Pagamento.ToString();
            }
            else
            {
                ID_Forma_de_Pagamento = "NULL";
            }
            if(lancamento.Baixa != null)
            {
                Baixa = "'" + lancamento.Baixa.ToString("yyyyMMdd") + "'";
            }
            else
            {
                Baixa = "NULL";
            }
            if(lancamento.Descricao != null)
            {
                Descricao = "'" + lancamento.Descricao.ToString() + "'";
            }
            else
            {
                Descricao = "NULL";
            }
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            string comando = string.Format("EXECUTE InserirLancamento '{0}', {1}, {2}, '{3}', '{4}', '{5}', {6}, {7}, {8}, {9}, {10}, {11}, {12}", lancamento.Nome, lancamento.Valor.ToString().Replace(",","."), lancamento.Desconto_Comissao.ToString().Replace(",","."), lancamento.Emissao.ToString("yyyyMMdd"), lancamento.Vencimento.ToString("yyyyMMdd"), lancamento._Status, lancamento.Venda.ToString(), ID_Usuario, ID_Natureza, ID_Conta, ID_Forma_de_Pagamento, Baixa, Descricao);
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
        public async Task<SqlDataAdapter> BuscarLancamento()
        {
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            SqlCommand cmd = new SqlCommand("EXECUTE BuscaLancamento", sqlConn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            return adapter;
        }
        public async Task<SqlDataAdapter> BuscarLancamento(int ID)
        {
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            string comando = string.Format("EXECUTE BuscaLancamentoID '{0}'", ID.ToString());
            SqlCommand cmd = new SqlCommand(comando, sqlConn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            return adapter;
        }

        //Método de atualização
        public async ValueTask<string> AtualizarLancamento(Lancamento lancamento)
        {
            string ID_Usuario, ID_Natureza, ID_Conta, ID_Forma_de_Pagamento, Baixa, Descricao;
            if (lancamento.ID_Usuario != null)
            {
                ID_Usuario = lancamento.ID_Usuario.ToString();
            }
            else
            {
                ID_Usuario = "NULL";
            }
            if (lancamento.ID_Natureza != null)
            {
                ID_Natureza = lancamento.ID_Natureza.ToString();
            }
            else
            {
                ID_Natureza = "NULL";
            }
            if (lancamento.ID_Conta != null)
            {
                ID_Conta = lancamento.ID_Conta.ToString();
            }
            else
            {
                ID_Conta = "NULL";
            }
            if (lancamento.ID_Forma_de_Pagamento != null)
            {
                ID_Forma_de_Pagamento = lancamento.ID_Forma_de_Pagamento.ToString();
            }
            else
            {
                ID_Forma_de_Pagamento = "NULL";
            }
            if (lancamento.Baixa != null)
            {
                Baixa = "'" + lancamento.Baixa.ToString("yyyyMMdd") + "'";
            }
            else
            {
                Baixa = "NULL";
            }
            if (lancamento.Descricao != null)
            {
                Descricao = "'" + lancamento.Descricao.ToString() + "'";
            }
            else
            {
                Descricao = "NULL";
            }
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            string comando = string.Format("EXECUTE AtualizarLancamento {0}, '{1}', {2}, {3}, '{4}', '{5}', '{6}', {7}, {8}, {9}, {10}, {11}, {12}, {13}", lancamento.ID.ToString(),lancamento.Nome, lancamento.Valor.ToString().Replace(",", "."), lancamento.Desconto_Comissao.ToString().Replace(",", "."), lancamento.Emissao.ToString("yyyyMMdd"), lancamento.Vencimento.ToString("yyyyMMdd"), lancamento._Status, lancamento.Venda.ToString(), ID_Usuario, ID_Natureza, ID_Conta, ID_Forma_de_Pagamento, Baixa, Descricao);
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
        public async ValueTask<string> DeletarLancamento(int ID)
        {
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            string comando = string.Format("EXECUTE DeletarLancamentoID '{0}'", ID.ToString());
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
