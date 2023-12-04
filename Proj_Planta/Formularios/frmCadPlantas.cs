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
    public partial class frmCadPlantas : Form
    {
        public frmCadPlantas()
        {
            InitializeComponent();
        }

        private void tb_PlantaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_PlantaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_PlantaDataSet);

        }

        private void frmCadPlantas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dB_PlantaDataSet.Tb_Planta'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_PlantaTableAdapter.Fill(this.dB_PlantaDataSet.Tb_Planta);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Você tem certeza que deseja excluir?","Para! Para!",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)== DialogResult.Yes)
            {
                tb_PlantaBindingSource.RemoveCurrent();
                this.tableAdapterManager.UpdateAll(this.dB_PlantaDataSet);
            }
        }
    }
}
