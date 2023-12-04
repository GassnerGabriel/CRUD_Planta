namespace Proj_Planta.Formularios
{
    partial class frmRelatorioFiltroTipo
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
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.tiposPlantasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_PlantaDataSet = new Proj_Planta.Dados.DB_PlantaDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnTodos = new System.Windows.Forms.Button();
            this.tbPlantaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_PlantaTableAdapter = new Proj_Planta.Dados.DB_PlantaDataSetTableAdapters.Tb_PlantaTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tipos_PlantasTableAdapter = new Proj_Planta.Dados.DB_PlantaDataSetTableAdapters.Tipos_PlantasTableAdapter();
            this.tbPlantaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tiposPlantasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_PlantaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPlantaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPlantaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTipo
            // 
            this.cmbTipo.DataSource = this.tiposPlantasBindingSource;
            this.cmbTipo.DisplayMember = "Tipo";
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(33, 34);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 1;
            this.cmbTipo.ValueMember = "Tipo";
            // 
            // tiposPlantasBindingSource
            // 
            this.tiposPlantasBindingSource.DataMember = "Tipos_Plantas";
            this.tiposPlantasBindingSource.DataSource = this.dB_PlantaDataSet;
            // 
            // dB_PlantaDataSet
            // 
            this.dB_PlantaDataSet.DataSetName = "DB_PlantaDataSet";
            this.dB_PlantaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipos";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(227, 32);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 4;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(353, 34);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(75, 23);
            this.btnTodos.TabIndex = 5;
            this.btnTodos.Text = "Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // tbPlantaBindingSource
            // 
            this.tbPlantaBindingSource.DataMember = "Tb_Planta";
            this.tbPlantaBindingSource.DataSource = this.dB_PlantaDataSet;
            this.tbPlantaBindingSource.CurrentChanged += new System.EventHandler(this.tbPlantaBindingSource_CurrentChanged);
            // 
            // tb_PlantaTableAdapter
            // 
            this.tb_PlantaTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DataSetTipo";
            reportDataSource1.Value = this.tbPlantaBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proj_Planta.Relatório.RelatorioFiltroTipo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 97);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 353);
            this.reportViewer1.TabIndex = 6;
            // 
            // tipos_PlantasTableAdapter
            // 
            this.tipos_PlantasTableAdapter.ClearBeforeFill = true;
            // 
            // tbPlantaBindingSource1
            // 
            this.tbPlantaBindingSource1.DataMember = "Tb_Planta";
            this.tbPlantaBindingSource1.DataSource = this.dB_PlantaDataSet;
            // 
            // frmRelatorioFiltroTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTipo);
            this.Name = "frmRelatorioFiltroTipo";
            this.Text = "Relatorio por Tipo de Planta";
            this.Load += new System.EventHandler(this.frmRelatorioFiltroTipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tiposPlantasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_PlantaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPlantaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPlantaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnTodos;
        private Dados.DB_PlantaDataSet dB_PlantaDataSet;
        private System.Windows.Forms.BindingSource tbPlantaBindingSource;
        private Dados.DB_PlantaDataSetTableAdapters.Tb_PlantaTableAdapter tb_PlantaTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tiposPlantasBindingSource;
        private Dados.DB_PlantaDataSetTableAdapters.Tipos_PlantasTableAdapter tipos_PlantasTableAdapter;
        private System.Windows.Forms.BindingSource tbPlantaBindingSource1;
    }
}