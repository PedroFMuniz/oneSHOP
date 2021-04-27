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
        int IDPessoa;
        List<ProdutoPedidoNome> lista = new List<ProdutoPedidoNome>();
        public formNovoPedido()
        {
            InitializeComponent();
        }
        private void AtualizarGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lista;
            txtPesquisaProdutoPedido.Text = null;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            formBuscaPessoa formBuscaPessoa = new formBuscaPessoa();
            formBuscaPessoa.ShowDialog();
            if(formBuscaPessoa.DialogResult == DialogResult.OK)
            {
                IDPessoa = formBuscaPessoa.Id;
                txtRevendedor.Text = formBuscaPessoa.Nome;
                txtCpfPedido.Text = formBuscaPessoa.CPF;
            }
        }

        private async void txtPesquisaProdutoPedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                int i = -1;
                bool verificador = false;
                Produto produto1 = new Produto();
                SqlDataAdapter adapter = await produto1.BuscarProduto2(txtPesquisaProdutoPedido.Text);
                DataTable data = new DataTable();
                adapter.Fill(data);
                if (data.Rows.Count < 1)
                {
                    MessageBox.Show("Produto não encontrado", "Erro", MessageBoxButtons.OK);
                    txtPesquisaProdutoPedido.Text = null;
                }
                else
                {
                    foreach (ProdutoPedidoNome p in lista)
                    {
                        i++;
                        if (p.Codigo == txtPesquisaProdutoPedido.Text)
                        {
                            verificador = true;
                            continue;
                        }
                    }
                    if (verificador)
                    {
                        lista[i].Quantidade++;
                        AtualizarGrid();
                    }
                    else
                    {
                        ProdutoPedidoNome produto = new ProdutoPedidoNome()
                        {
                            Codigo = data.Rows[0]["Codigo"].ToString(),
                            Nome = data.Rows[0]["Nome"].ToString(),
                            Preco = float.Parse(data.Rows[0]["Preco_Venda"].ToString()),
                            Quantidade = 1
                        };
                        lista.Add(produto);
                        AtualizarGrid();
                    }
                }
            }
        }

        private void formNovoPedido_Load(object sender, EventArgs e)
        {
            
        }
    }
}
