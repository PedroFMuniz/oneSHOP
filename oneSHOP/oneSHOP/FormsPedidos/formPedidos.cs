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
    public partial class formPedidos : Form
    {
        public formPedidos()
        {
            InitializeComponent();
        }

        private void novoMovimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formNovoPedido form = new formNovoPedido();
            form.ShowDialog();
        }
    }
}
