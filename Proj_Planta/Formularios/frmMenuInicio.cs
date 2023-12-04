using Proj_Planta.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_Planta
{
    public partial class frmMenuInicio : Form
    {
        public frmMenuInicio()
        {
            InitializeComponent();
        }

        private void novoCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadPlantas objCadPlantas = new frmCadPlantas();
            objCadPlantas.MdiParent = this;
            objCadPlantas.Show();
        }

        private void novaConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaPlanta objColsultaPlanta = new frmConsultaPlanta();
            objColsultaPlanta.MdiParent = this;
            objColsultaPlanta.Show();
        }

        private void novoReToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmListagemPlantas objListagemPlanta = new frmListagemPlantas();
            objListagemPlanta.MdiParent = this;
            objListagemPlanta.Show();
        }

        private void plantasPorTipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorioFiltroTipo objRelatorioFiltroTipo = new frmRelatorioFiltroTipo();
            objRelatorioFiltroTipo.MdiParent = this;
            objRelatorioFiltroTipo.Show();
        }

        public void UpdateStatusLabel(string newtext) //Mostra qual o nome do usuario logado.
        {
            UsuarioLogado.Text = newtext;
        }

        private void trocarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin form = new frmLogin();
            form.Show();
            this.Hide();
        }

        private void frmMenuInicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
