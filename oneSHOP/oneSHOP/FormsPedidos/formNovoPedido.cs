using oneSHOP.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oneSHOP.FormsPedidos
{
    public partial class formNovoPedido : Form
    {
        //Variáveis globais
        bool verificador = false;
        int IDPessoa = 0;
        float limite = 0;
        float total = 0;
        new string Name;
        List<ProdutoPedidoNome> lista = new List<ProdutoPedidoNome>();
        public formNovoPedido()
        {
            InitializeComponent();
        }
        //Método para atualizar label
        private void AtualizarLabel()
        {
            int quantidade = 0;
            total = 0;
            foreach (ProdutoPedidoNome p in lista)
            {
                quantidade++;
                total += p.Preco * p.Quantidade;
            }
            lblQnt.Text = string.Format("Quantidade total: {0}", quantidade.ToString());
            lblValor.Text = string.Format("Valor total: {0}", total.ToString("C"));
            lblLimite.Text = string.Format("Limite: {0}", limite.ToString("C"));
        }
        //Método para atualizar o datagridview
        private void AtualizarGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lista;
            txtPesquisaProdutoPedido.Text = null;
            dataGridView1.Columns[4].Visible = false;
            AtualizarLabel();
        }
        //Abrir uma janela para selecionar a pessoa do pedido
        private async void button1_Click(object sender, EventArgs e)
        {
            //Abrindo a janela
            formBuscaPessoa formBuscaPessoa = new formBuscaPessoa();
            formBuscaPessoa.ShowDialog();
            //Obtendo os dados da pessoa
            if(formBuscaPessoa.DialogResult == DialogResult.OK)
            {
                IDPessoa = formBuscaPessoa.Id;
                Name = formBuscaPessoa.Nome;
                txtRevendedor.Text = formBuscaPessoa.Nome;
                txtCpfPedido.Text = formBuscaPessoa.CPF;
            }
            Pessoa pessoa = new Pessoa();
            SqlDataAdapter adapter = await pessoa.BuscarPessoa(IDPessoa);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            limite = float.Parse(dataTable.Rows[0]["Fator_de_limite"].ToString());
            AtualizarLabel();
        }

        private async void txtPesquisaProdutoPedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IDPessoa == 0)
            {
                MessageBox.Show("Por favor informe a consultora", "Erro");
                verificador = true;
            }
            else
            {
                //Pesquisar produto por código ao apertar enter
                if (e.KeyChar == 13)
                {
                    //Variáveis
                    int i = -1;
                    bool verificador = false;
                    //Pesquisando o produto pelo código
                    Produto produto1 = new Produto();
                    SqlDataAdapter adapter = await produto1.BuscarProduto2(txtPesquisaProdutoPedido.Text);
                    DataTable data = new DataTable();
                    adapter.Fill(data);
                    //Verificando se o BD possui o produto
                    if (data.Rows.Count < 1)
                    {
                        MessageBox.Show("Produto não encontrado", "Erro", MessageBoxButtons.OK);
                        txtPesquisaProdutoPedido.Text = null;
                    }
                    else
                    {
                        //Verificando se o limite foi excedido
                        if (total + int.Parse(data.Rows[0]["Preco_Venda"].ToString()) > limite)
                        {
                            MessageBox.Show("O limite da consultora foi excedido, favor verificar", "Erro", MessageBoxButtons.OK);
                            AtualizarGrid();
                        }
                        else
                        {
                            //Verificando se já possui o produto no pedido
                            foreach (ProdutoPedidoNome p in lista)
                            {
                                i++;
                                if (p.Codigo == txtPesquisaProdutoPedido.Text)
                                {
                                    verificador = true;
                                    break;
                                }
                            }
                            //Se tiver, incrementar a quantidade do produto no pedido
                            if (verificador)
                            {
                                lista[i].Quantidade++;
                                AtualizarGrid();
                            }
                            //Se não, inserir produto no pedido
                            else
                            {
                                ProdutoPedidoNome produto = new ProdutoPedidoNome()
                                {
                                    Codigo = data.Rows[0]["Codigo"].ToString(),
                                    Nome = data.Rows[0]["Nome"].ToString(),
                                    Preco = float.Parse(data.Rows[0]["Preco_Venda"].ToString()),
                                    Quantidade = 1,
                                    IDProduto = int.Parse(data.Rows[0]["ID"].ToString())
                                };
                                lista.Add(produto);
                                AtualizarGrid();
                            }
                        }
                    }
                }
            }
        }
        //Incluir pedido no BD e seus produtos
        private async void btnGravar_Click(object sender, EventArgs e)
        {
            //Variáveis
            float somaValores = 0;
            //Obtendo o total do pedido
            foreach(ProdutoPedidoNome p in lista)
            {
                somaValores += float.Parse(p.Preco.ToString());
            }
            //Incluindo pedido no BD
            Pedido pedido = new Pedido()
            {
                Nome = Name,
                Valor = somaValores,
                ID_Pessoa = IDPessoa,
                ID_Usuario = null,
                Observacoes = null,
                Valor_de_Comissao = 0,
                Valor_de_Venda = 0,
                Valor_Recebimento = 0,
                _Status = "Aberto"
            };
            await pedido.IncluirPedido(pedido);
            //Pegando o pedido cadastrado
            SqlDataAdapter adapter = await pedido.BuscarPedido();
            DataTable data = new DataTable();
            Produto produto = new Produto();
            adapter.Fill(data);
            foreach(ProdutoPedidoNome p in lista)
            {
                //Atualizando o estoque dos produtos
                SqlDataAdapter adapter1 = await produto.BuscarProduto(p.IDProduto);
                DataTable data1 = new DataTable();
                adapter1.Fill(data1);
                await produto.AtualizarProduto(p.IDProduto, int.Parse(data1.Rows[0]["Qt_Estoque"].ToString()) - p.Quantidade, int.Parse(data1.Rows[0]["Qt_Rua"].ToString()) + p.Quantidade);
                //Incluindo os registros de tabela de ligação
                Pedido_Produto pedido_Produto = new Pedido_Produto()
                {
                    ID_Pedido = int.Parse(data.Rows[data.Rows.Count - 1]["ID"].ToString()),
                    ID_Produto = p.IDProduto,
                    Quantidade = p.Quantidade,
                    Valor_Produto = p.Preco,
                };
                await pedido_Produto.IncluirPedido_Produto(pedido_Produto);
            }
            this.Close();
        }

        private void txtPesquisaProdutoPedido_TextChanged(object sender, EventArgs e)
        {
            if (verificador)
            {
                
                txtPesquisaProdutoPedido.Text = null;
                verificador = false;
            }
        }
    }
}
