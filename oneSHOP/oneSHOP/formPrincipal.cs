using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oneSHOP
{
    public partial class formPrincipal : Form
    {
        public formPrincipal()
       {
            InitializeComponent();
        }

        private void formPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCadastros formCadastros = new formCadastros();
            formCadastros.ShowDialog();
        }

        private void consignadoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
