using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_Planta.Formularios
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            if ((txtUsuario.Text.Equals("admin") && txtSenha.Text.Equals(""))
              || txtUsuario.Text.Equals("Gabriel") && txtSenha.Text.Equals("123")
              || txtUsuario.Text.Equals("Rodrigo") && txtSenha.Text.Equals("123"))
            {
                //limitador++;
                frmMenuInicio objMenu = new frmMenuInicio();
                objMenu.Show();

                objMenu.UpdateStatusLabel(txtUsuario.Text); //muda o nome do Usuario logado

                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuario ou senha errado, tente novamente",
                                "Opa!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtSenha.Clear();
            txtUsuario.Focus();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            txtUsuario.BackColor = System.Drawing.Color.LightGreen;
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            txtUsuario.BackColor = System.Drawing.Color.White;
        }

        private void btnLimpar_Leave(object sender, EventArgs e)
        {
            txtUsuario.BackColor = System.Drawing.Color.White;
        }

        private void btnLimpar_Enter(object sender, EventArgs e)
        {
            txtUsuario.BackColor = System.Drawing.Color.LightGreen;
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            int tecla = (int)e.KeyChar;

            if (!char.IsLetterOrDigit(e.KeyChar) && tecla != 8)
            {
                e.Handled = true;
                MessageBox.Show("Digite apenas letras ou numeros",
                                "Calma ae meu nobre!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }
    }
}
