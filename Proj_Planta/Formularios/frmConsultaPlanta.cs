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
    public partial class frmConsultaPlanta : Form
    {
        public frmConsultaPlanta()
        {
            InitializeComponent();
        }

        private void tb_PlantaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_PlantaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_PlantaDataSet);

        }

        private void frmConsultaPlanta_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dB_PlantaDataSet.Tb_Planta'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_PlantaTableAdapter.Fill(this.dB_PlantaDataSet.Tb_Planta);

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string vColuna, vProcurar, vTexto, vFiltro;

            vColuna = cmbColuna.Text;
            vProcurar = cmbProcura.Text;
            vTexto = txtPesquisa.Text;

            vFiltro = vColuna;

            if(vProcurar == "Que começa com") 
            {
                vFiltro += " like '" + vTexto + "%'";
            }
            else if(vProcurar == "Que contém") 
            {
                vFiltro += " like '%" + vTexto + "%'";
            }
            else if (vProcurar == "Que termina com") 
            {
                vFiltro += " like '%" + vTexto + "'";
            }
            else if( vProcurar == "Igual a")
            {
                vFiltro += " = '" + vTexto + "'";
            }
            else
            {
                vFiltro = "";
            }

            tb_PlantaBindingSource.Filter = vFiltro;
        }
    }
}
