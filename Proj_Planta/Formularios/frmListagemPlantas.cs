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
    public partial class frmListagemPlantas : Form
    {
        public frmListagemPlantas()
        {
            InitializeComponent();
        }

        private void frmListagemPlantas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dB_PlantaDataSet.Tb_Planta'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_PlantaTableAdapter.Fill(this.dB_PlantaDataSet.Tb_Planta);

            this.reportViewer1.RefreshReport();
        }
    }
}
