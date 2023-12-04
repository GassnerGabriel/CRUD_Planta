namespace Proj_Planta.Formularios
{
    partial class frmListagemPlantas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListagemPlantas));
            this.Tb_PlantaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_PlantaDataSet = new Proj_Planta.Dados.DB_PlantaDataSet();
            this.tbPlantaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBPlantaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tb_PlantaTableAdapter = new Proj_Planta.Dados.DB_PlantaDataSetTableAdapters.Tb_PlantaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Tb_PlantaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_PlantaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPlantaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPlantaDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Tb_PlantaBindingSource
            // 
            this.Tb_PlantaBindingSource.DataMember = "Tb_Planta";
            this.Tb_PlantaBindingSource.DataSource = this.dB_PlantaDataSet;
            // 
            // dB_PlantaDataSet
            // 
            this.dB_PlantaDataSet.DataSetName = "DB_PlantaDataSet";
            this.dB_PlantaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbPlantaBindingSource
            // 
            this.tbPlantaBindingSource.DataMember = "Tb_Planta";
            this.tbPlantaBindingSource.DataSource = this.dBPlantaDataSetBindingSource;
            // 
            // dBPlantaDataSetBindingSource
            // 
            this.dBPlantaDataSetBindingSource.DataSource = this.dB_PlantaDataSet;
            this.dBPlantaDataSetBindingSource.Position = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet_Plantas";
            reportDataSource1.Value = this.Tb_PlantaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proj_Planta.Relatório.RelatorioPlantas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // tb_PlantaTableAdapter
            // 
            this.tb_PlantaTableAdapter.ClearBeforeFill = true;
            // 
            // frmListagemPlantas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListagemPlantas";
            this.Text = "frmListagemPlantas";
            this.Load += new System.EventHandler(this.frmListagemPlantas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tb_PlantaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_PlantaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPlantaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPlantaDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dBPlantaDataSetBindingSource;
        private Dados.DB_PlantaDataSet dB_PlantaDataSet;
        private System.Windows.Forms.BindingSource tbPlantaBindingSource;
        private Dados.DB_PlantaDataSetTableAdapters.Tb_PlantaTableAdapter tb_PlantaTableAdapter;
        private System.Windows.Forms.BindingSource Tb_PlantaBindingSource;
    }
}