using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oneSHOP.Classes
{
    class Pessoa
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Funcao { get; set; }
        public int Verifica_Comissao { get; set; }
        public string CEP { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public Nullable<int> ID_Usuario { get; set; }
        public Nullable<int> ID_Praca { get; set; }
        public Nullable<float> Comissao { get; set; }
        public Nullable<int> Fator_de_limite { get; set; }
        public string Foto { get; set; }
        public DateTime Nascimento { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        public async ValueTask<string> IncluirPessoa(Pessoa pessoa)
        {
            string ID_Usuario, ID_Praca, Comissao, Fator_de_limite, Foto, Nascimento, Email, Telefone;
            if(pessoa.ID_Usuario != null)
            {
                ID_Usuario = pessoa.ID_Usuario.ToString();
            }
            else
            {
                ID_Usuario = "NULL";
            }
            if (pessoa.ID_Praca != null)
            {
                ID_Praca = pessoa.ID_Praca.ToString();
            }
            else
            {
                ID_Praca = "NULL";
            }
            if(pessoa.Comissao != null)
            {
                Comissao = pessoa.Comissao.ToString().Replace(",", ".");
            }
            else
            {
                Comissao = "NULL";
            }
            if(pessoa.Fator_de_limite != null)
            {
                Fator_de_limite = pessoa.Fator_de_limite.ToString();
            }
            else
            {
                Fator_de_limite = "NULL";
            }
            if(pessoa.Foto != null)
            {
                Foto = "'" + pessoa.Foto.ToString() + "'";
            }
            else
            {
                Foto = "NULL";
            }
            if(pessoa.Nascimento != null)
            {
                Nascimento = "'" + pessoa.Nascimento.ToString("yyyyMMdd") + "'";
            }
            else
            {
                Nascimento = "NULL";
            }
            if(pessoa.Email != null)
            {
                Email = "'" + pessoa.Email.ToString() + "'";
            }
            else
            {
                Email = "NULL";
            }
            if (pessoa.Telefone != null)
            {
                Telefone = "'" + pessoa.Telefone.ToString() + "'";
            }
            else
            {
                Telefone = "NULL";
            }
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            string comando = string.Format("EXECUTE InserirPessoa '{0}', '{1}', '{2}', {3}, '{4}', '{5}', '{6}', '{7}', '{8}', {9}, {10}, {11}, {12}, {13}, {14}, {15}, {16}", pessoa.Nome, pessoa.CPF, pessoa.Funcao, pessoa.Verifica_Comissao.ToString(), pessoa.CEP,pessoa.Endereco, pessoa.Bairro, pessoa.Cidade, pessoa.UF, ID_Usuario, ID_Praca, Comissao, Fator_de_limite, Foto, Nascimento, Email, Telefone);
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
        public async Task<SqlDataAdapter> BuscarPessoa()
        {
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            SqlCommand cmd = new SqlCommand("EXECUTE BuscaPessoa", sqlConn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            return adapter;
        }
        public async Task<SqlDataAdapter> BuscarPessoa(int ID)
        {
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            string comando = string.Format("EXECUTE BuscaPessoaID {0}", ID.ToString());
            SqlCommand cmd = new SqlCommand(comando, sqlConn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            return adapter;
        }
        public async Task<SqlDataAdapter> BuscarPessoa(string nome)
        {
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            string comando = string.Format("EXECUTE BuscaPessoaNome '{0}'", nome);
            SqlCommand cmd = new SqlCommand(comando, sqlConn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            return adapter;
        }
        public async Task<SqlDataAdapter> BuscarPessoa2(string nome)
        {
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            string comando = string.Format("EXECUTE BuscaPessoaNome2 '{0}'", nome);
            SqlCommand cmd = new SqlCommand(comando, sqlConn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            return adapter;
        }

        //Método de atualização
        public async ValueTask<string> AtualizarPessoa(Pessoa pessoa)
        {
            string ID_Usuario, ID_Praca, Comissao, Fator_de_limite, Foto, Nascimento, Email, Telefone;
            if (pessoa.ID_Usuario != null)
            {
                ID_Usuario = pessoa.ID_Usuario.ToString();
            }
            else
            {
                ID_Usuario = "NULL";
            }
            if (pessoa.ID_Praca != null)
            {
                ID_Praca = pessoa.ID_Praca.ToString();
            }
            else
            {
                ID_Praca = "NULL";
            }
            if (pessoa.Comissao != null)
            {
                Comissao = pessoa.Comissao.ToString().Replace(",", ".");
            }
            else
            {
                Comissao = "NULL";
            }
            if (pessoa.Fator_de_limite != null)
            {
                Fator_de_limite = pessoa.Fator_de_limite.ToString();
            }
            else
            {
                Fator_de_limite = "NULL";
            }
            if (pessoa.Foto != null)
            {
                Foto = "'" + pessoa.Foto.ToString() + "'";
            }
            else
            {
                Foto = "NULL";
            }
            if (pessoa.Nascimento != null)
            {
                Nascimento = "'" + pessoa.Nascimento.ToString("yyyyMMdd") + "'";
            }
            else
            {
                Nascimento = "NULL";
            }
            if (pessoa.Email != null)
            {
                Email = "'" + pessoa.Email.ToString() + "'";
            }
            else
            {
                Email = "NULL";
            }
            if (pessoa.Telefone != null)
            {
                Telefone = "'" + pessoa.Telefone.ToString() + "'";
            }
            else
            {
                Telefone = "NULL";
            }
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            string comando = string.Format("EXECUTE AtualizarPessoa {0}, '{1}', '{2}', '{3}', {4}, '{5}', '{6}', '{7}', '{8}', '{9}', {10}, {11}, {12}, {13}, {14}, {15}, {16}, {17}", pessoa.ID.ToString(),pessoa.Nome, pessoa.CPF, pessoa.Funcao, pessoa.Verifica_Comissao.ToString(), pessoa.CEP, pessoa.Endereco, pessoa.Bairro, pessoa.Cidade, pessoa.UF, ID_Usuario, ID_Praca, Comissao, Fator_de_limite, Foto, Nascimento, Email, Telefone);
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
        public async ValueTask<string> DeletarPessoa(int ID)
        {
            string connectionString = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database =  " + ConfigurationManager.AppSettings["BD"] + "; Trusted_Connection = True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            string comando = string.Format("EXECUTE DeletarPessoaID '{0}'", ID.ToString());
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
