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
    }
}
