using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public formNovoPedido()
        {
            InitializeComponent();
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
    }
}
