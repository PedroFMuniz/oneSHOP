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
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }
        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "Digite o usuário...")
            {
                txtUsuario.Text = string.Empty;
            }
        }

        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "")
            {
                txtUsuario.Text = "Digite o usuário...";
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if(txtSenha.Text == "Digite a senha...")
            {
                txtSenha.Text = string.Empty;
            }
        }
    }
}
