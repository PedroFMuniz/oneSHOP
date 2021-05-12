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
    public partial class formPedidos : Form
    {
        List<Pedido> pedidos = new List<Pedido>();
        public formPedidos()
        {
            InitializeComponent();
        }
        private async void AtualizaGrid()
        {
            Pedido pedido = new Pedido();
            SqlDataAdapter adapter = await pedido.BuscarPedido2();
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        private void novoMovimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formNovoPedido form = new formNovoPedido();
            form.ShowDialog();
            AtualizaGrid();
        }

        private void formPedidos_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        private async void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dataGridView1.CurrentRow.Cells[0].Value.ToString() == "Aberto")
                {
                    if (MessageBox.Show("Tem certeza que deseja excluir este pedido?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Pedido pedido = new Pedido();
                        DeletarProdutos(int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString()));
                        await pedido.DeletarPedido(int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString()));
                        AtualizaGrid();
                    }
                }
            }
        }
        private async void DeletarProdutos(int id)
        {
            Produto produto = new Produto();
            Pedido_Produto pedido_Produto = new Pedido_Produto();
            SqlDataAdapter adapter = await pedido_Produto.BuscarPedido_Produto2(id);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            foreach(DataRow dataRow in dataTable.Rows)
            {
                SqlDataAdapter adapter1 = await produto.BuscarProduto(int.Parse(dataRow["ID_Produto"].ToString()));
                DataTable dataTable1 = new DataTable();
                adapter1.Fill(dataTable1);
                await produto.AtualizarProduto(int.Parse(dataRow["ID_Produto"].ToString()), int.Parse(dataTable1.Rows[0]["QT_Estoque"].ToString()) + int.Parse(dataRow["Quantidade"].ToString()), int.Parse(dataTable1.Rows[0]["QT_Rua"].ToString()) - int.Parse(dataRow["Quantidade"].ToString()));
            }
            await pedido_Produto.DeletarPedido_Produto2(int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString()));
        }
    }
}
