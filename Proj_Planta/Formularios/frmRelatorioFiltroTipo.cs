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
    public partial class frmRelatorioFiltroTipo : Form
    {
        public frmRelatorioFiltroTipo()
        {
            InitializeComponent();
        }

        private void frmRelatorioFiltroTipo_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dB_PlantaDataSet.Tipos_Plantas'. Você pode movê-la ou removê-la conforme necessário.
            this.tipos_PlantasTableAdapter.Fill(this.dB_PlantaDataSet.Tipos_Plantas);
            // TODO: esta linha de código carrega dados na tabela 'dB_PlantaDataSet.Tb_Planta'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_PlantaTableAdapter.Fill(this.dB_PlantaDataSet.Tb_Planta);
            // TODO: esta linha de código carrega dados na tabela 'dB_PlantaDataSet.Tb_Planta'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_PlantaTableAdapter.Fill(this.dB_PlantaDataSet.Tb_Planta);
            // TODO: esta linha de código carrega dados na tabela 'dB_PlantaDataSet.Tipos_Plantas'. Você pode movê-la ou removê-la conforme necessário.
            this.tipos_PlantasTableAdapter.Fill(this.dB_PlantaDataSet.Tipos_Plantas);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Tipo", (cmbTipo.Text)));
            this.reportViewer1.RefreshReport();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Tipo", (string)(null)));
            this.reportViewer1.RefreshReport();
        }

        private void tbPlantaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
