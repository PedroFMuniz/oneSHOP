using oneSHOP.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oneSHOP.FormsPedidos
{
    public partial class formBuscaPessoa : Form
    {
        public formBuscaPessoa()
        {
            InitializeComponent();
        }

        private async void textBox1_TextChanged(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            SqlDataAdapter sqlDataAdapter = await pessoa.BuscarPessoa2(textBox1.Text);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
    }
}
