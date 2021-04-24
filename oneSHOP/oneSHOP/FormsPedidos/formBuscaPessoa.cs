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
        private async void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox1.Text != "")
            {
                Pessoa pessoa = new Pessoa();
                SqlDataAdapter adapter = await pessoa.BuscarPessoa(textBox1.Text.Trim());
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "Pessoas");
                foreach (DataRow row in dataSet.Tables["Pessoas"].Rows)
                {
                    string mensagem = row["ID"].ToString() + "\n";
                    listView1.Items.Add(mensagem);
                }
            }
            else
            {
                listView1.Items.Clear();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            listView1.Items.Clear();
        }
    }
}
