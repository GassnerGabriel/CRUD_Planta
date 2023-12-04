namespace Proj_Planta.Formularios
{
    partial class frmCadPlantas
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label nome_CientificoLabel;
            System.Windows.Forms.Label nome_PopularLabel;
            System.Windows.Forms.Label tipoLabel;
            System.Windows.Forms.Label data_PlantacaoLabel;
            System.Windows.Forms.Label data_ColheitaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadPlantas));
            this.dB_PlantaDataSet = new Proj_Planta.Dados.DB_PlantaDataSet();
            this.tb_PlantaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_PlantaTableAdapter = new Proj_Planta.Dados.DB_PlantaDataSetTableAdapters.Tb_PlantaTableAdapter();
            this.tableAdapterManager = new Proj_Planta.Dados.DB_PlantaDataSetTableAdapters.TableAdapterManager();
            this.tb_PlantaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tb_PlantaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.nome_CientificoTextBox = new System.Windows.Forms.TextBox();
            this.nome_PopularTextBox = new System.Windows.Forms.TextBox();
            this.tipoTextBox = new System.Windows.Forms.TextBox();
            this.data_PlantacaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.data_ColheitaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tb_PlantaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iDLabel = new System.Windows.Forms.Label();
            nome_CientificoLabel = new System.Windows.Forms.Label();
            nome_PopularLabel = new System.Windows.Forms.Label();
            tipoLabel = new System.Windows.Forms.Label();
            data_PlantacaoLabel = new System.Windows.Forms.Label();
            data_ColheitaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_PlantaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_PlantaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_PlantaBindingNavigator)).BeginInit();
            this.tb_PlantaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_PlantaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(248, 55);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // nome_CientificoLabel
            // 
            nome_CientificoLabel.AutoSize = true;
            nome_CientificoLabel.Location = new System.Drawing.Point(248, 81);
            nome_CientificoLabel.Name = "nome_CientificoLabel";
            nome_CientificoLabel.Size = new System.Drawing.Size(84, 13);
            nome_CientificoLabel.TabIndex = 3;
            nome_CientificoLabel.Text = "Nome Cientifico:";
            // 
            // nome_PopularLabel
            // 
            nome_PopularLabel.AutoSize = true;
            nome_PopularLabel.Location = new System.Drawing.Point(248, 107);
            nome_PopularLabel.Name = "nome_PopularLabel";
            nome_PopularLabel.Size = new System.Drawing.Size(77, 13);
            nome_PopularLabel.TabIndex = 5;
            nome_PopularLabel.Text = "Nome Popular:";
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Location = new System.Drawing.Point(248, 133);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(31, 13);
            tipoLabel.TabIndex = 7;
            tipoLabel.Text = "Tipo:";
            // 
            // data_PlantacaoLabel
            // 
            data_PlantacaoLabel.AutoSize = true;
            data_PlantacaoLabel.Location = new System.Drawing.Point(248, 160);
            data_PlantacaoLabel.Name = "data_PlantacaoLabel";
            data_PlantacaoLabel.Size = new System.Drawing.Size(84, 13);
            data_PlantacaoLabel.TabIndex = 9;
            data_PlantacaoLabel.Text = "Data Plantacao:";
            // 
            // data_ColheitaLabel
            // 
            data_ColheitaLabel.AutoSize = true;
            data_ColheitaLabel.Location = new System.Drawing.Point(248, 186);
            data_ColheitaLabel.Name = "data_ColheitaLabel";
            data_ColheitaLabel.Size = new System.Drawing.Size(74, 13);
            data_ColheitaLabel.TabIndex = 11;
            data_ColheitaLabel.Text = "Data Colheita:";
            // 
            // dB_PlantaDataSet
            // 
            this.dB_PlantaDataSet.DataSetName = "DB_PlantaDataSet";
            this.dB_PlantaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_PlantaBindingSource
            // 
            this.tb_PlantaBindingSource.DataMember = "Tb_Planta";
            this.tb_PlantaBindingSource.DataSource = this.dB_PlantaDataSet;
            // 
            // tb_PlantaTableAdapter
            // 
            this.tb_PlantaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Tb_PlantaTableAdapter = this.tb_PlantaTableAdapter;
            this.tableAdapterManager.UpdateOrder = Proj_Planta.Dados.DB_PlantaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tb_PlantaBindingNavigator
            // 
            this.tb_PlantaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tb_PlantaBindingNavigator.BindingSource = this.tb_PlantaBindingSource;
            this.tb_PlantaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tb_PlantaBindingNavigator.DeleteItem = null;
            this.tb_PlantaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tb_PlantaBindingNavigatorSaveItem});
            this.tb_PlantaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tb_PlantaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tb_PlantaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tb_PlantaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tb_PlantaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tb_PlantaBindingNavigator.Name = "tb_PlantaBindingNavigator";
            this.tb_PlantaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tb_PlantaBindingNavigator.Size = new System.Drawing.Size(638, 25);
            this.tb_PlantaBindingNavigator.TabIndex = 0;
            this.tb_PlantaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // tb_PlantaBindingNavigatorSaveItem
            // 
            this.tb_PlantaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_PlantaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tb_PlantaBindingNavigatorSaveItem.Image")));
            this.tb_PlantaBindingNavigatorSaveItem.Name = "tb_PlantaBindingNavigatorSaveItem";
            this.tb_PlantaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tb_PlantaBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tb_PlantaBindingNavigatorSaveItem.Click += new System.EventHandler(this.tb_PlantaBindingNavigatorSaveItem_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_PlantaBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(338, 52);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(40, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // nome_CientificoTextBox
            // 
            this.nome_CientificoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_PlantaBindingSource, "Nome_Cientifico", true));
            this.nome_CientificoTextBox.Location = new System.Drawing.Point(338, 78);
            this.nome_CientificoTextBox.Name = "nome_CientificoTextBox";
            this.nome_CientificoTextBox.Size = new System.Drawing.Size(131, 20);
            this.nome_CientificoTextBox.TabIndex = 4;
            // 
            // nome_PopularTextBox
            // 
            this.nome_PopularTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_PlantaBindingSource, "Nome_Popular", true));
            this.nome_PopularTextBox.Location = new System.Drawing.Point(338, 104);
            this.nome_PopularTextBox.Name = "nome_PopularTextBox";
            this.nome_PopularTextBox.Size = new System.Drawing.Size(131, 20);
            this.nome_PopularTextBox.TabIndex = 6;
            // 
            // tipoTextBox
            // 
            this.tipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_PlantaBindingSource, "Tipo", true));
            this.tipoTextBox.Location = new System.Drawing.Point(338, 130);
            this.tipoTextBox.Name = "tipoTextBox";
            this.tipoTextBox.Size = new System.Drawing.Size(131, 20);
            this.tipoTextBox.TabIndex = 8;
            // 
            // data_PlantacaoDateTimePicker
            // 
            this.data_PlantacaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tb_PlantaBindingSource, "Data_Plantacao", true));
            this.data_PlantacaoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_PlantacaoDateTimePicker.Location = new System.Drawing.Point(338, 156);
            this.data_PlantacaoDateTimePicker.Name = "data_PlantacaoDateTimePicker";
            this.data_PlantacaoDateTimePicker.Size = new System.Drawing.Size(82, 20);
            this.data_PlantacaoDateTimePicker.TabIndex = 10;
            // 
            // data_ColheitaDateTimePicker
            // 
            this.data_ColheitaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tb_PlantaBindingSource, "Data_Colheita", true));
            this.data_ColheitaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_ColheitaDateTimePicker.Location = new System.Drawing.Point(338, 182);
            this.data_ColheitaDateTimePicker.Name = "data_ColheitaDateTimePicker";
            this.data_ColheitaDateTimePicker.Size = new System.Drawing.Size(82, 20);
            this.data_ColheitaDateTimePicker.TabIndex = 12;
            // 
            // tb_PlantaDataGridView
            // 
            this.tb_PlantaDataGridView.AutoGenerateColumns = false;
            this.tb_PlantaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_PlantaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.tb_PlantaDataGridView.DataSource = this.tb_PlantaBindingSource;
            this.tb_PlantaDataGridView.Location = new System.Drawing.Point(0, 235);
            this.tb_PlantaDataGridView.Name = "tb_PlantaDataGridView";
            this.tb_PlantaDataGridView.Size = new System.Drawing.Size(638, 279);
            this.tb_PlantaDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome_Cientifico";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome_Cientifico";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nome_Popular";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nome_Popular";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Tipo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Data_Plantacao";
            this.dataGridViewTextBoxColumn5.HeaderText = "Data_Plantacao";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Data_Colheita";
            this.dataGridViewTextBoxColumn6.HeaderText = "Data_Colheita";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // frmCadPlantas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 508);
            this.Controls.Add(this.tb_PlantaDataGridView);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(nome_CientificoLabel);
            this.Controls.Add(this.nome_CientificoTextBox);
            this.Controls.Add(nome_PopularLabel);
            this.Controls.Add(this.nome_PopularTextBox);
            this.Controls.Add(tipoLabel);
            this.Controls.Add(this.tipoTextBox);
            this.Controls.Add(data_PlantacaoLabel);
            this.Controls.Add(this.data_PlantacaoDateTimePicker);
            this.Controls.Add(data_ColheitaLabel);
            this.Controls.Add(this.data_ColheitaDateTimePicker);
            this.Controls.Add(this.tb_PlantaBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadPlantas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de novas plantas";
            this.Load += new System.EventHandler(this.frmCadPlantas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_PlantaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_PlantaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_PlantaBindingNavigator)).EndInit();
            this.tb_PlantaBindingNavigator.ResumeLayout(false);
            this.tb_PlantaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_PlantaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Dados.DB_PlantaDataSet dB_PlantaDataSet;
        private System.Windows.Forms.BindingSource tb_PlantaBindingSource;
        private Dados.DB_PlantaDataSetTableAdapters.Tb_PlantaTableAdapter tb_PlantaTableAdapter;
        private Dados.DB_PlantaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tb_PlantaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tb_PlantaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox nome_CientificoTextBox;
        private System.Windows.Forms.TextBox nome_PopularTextBox;
        private System.Windows.Forms.TextBox tipoTextBox;
        private System.Windows.Forms.DateTimePicker data_PlantacaoDateTimePicker;
        private System.Windows.Forms.DateTimePicker data_ColheitaDateTimePicker;
        private System.Windows.Forms.DataGridView tb_PlantaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}