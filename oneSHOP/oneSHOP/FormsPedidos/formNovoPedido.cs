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
        public formNovoPedido()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formBuscaPessoa formBuscaPessoa = new formBuscaPessoa();
            formBuscaPessoa.ShowDialog();
        }
    }
}
