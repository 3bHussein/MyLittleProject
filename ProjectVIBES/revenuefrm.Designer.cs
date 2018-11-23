namespace ProjectVIBES
{
    partial class revenuefrm
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label noteLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(revenuefrm));
            this.vibesDataSourcesDataSet = new ProjectVIBES.VibesDataSourcesDataSet();
            this.tb_RevinuesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_RevinuesTableAdapter = new ProjectVIBES.VibesDataSourcesDataSetTableAdapters.Tb_RevinuesTableAdapter();
            this.tableAdapterManager = new ProjectVIBES.VibesDataSourcesDataSetTableAdapters.TableAdapterManager();
            this.tb_RevinuesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tb_RevinuesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tb_RevinuesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            iDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            noteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vibesDataSourcesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_RevinuesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_RevinuesBindingNavigator)).BeginInit();
            this.tb_RevinuesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_RevinuesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(129, 60);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(25, 17);
            iDLabel.TabIndex = 2;
            iDLabel.Text = "ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(105, 88);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name:";
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.Location = new System.Drawing.Point(112, 116);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new System.Drawing.Size(42, 17);
            noteLabel.TabIndex = 6;
            noteLabel.Text = "Note:";
            // 
            // vibesDataSourcesDataSet
            // 
            this.vibesDataSourcesDataSet.DataSetName = "VibesDataSourcesDataSet";
            this.vibesDataSourcesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_RevinuesBindingSource
            // 
            this.tb_RevinuesBindingSource.DataMember = "Tb_Revinues";
            this.tb_RevinuesBindingSource.DataSource = this.vibesDataSourcesDataSet;
            // 
            // tb_RevinuesTableAdapter
            // 
            this.tb_RevinuesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.SourcesTableAdapter = null;
            this.tableAdapterManager.Tb_CategoriesTableAdapter = null;
            this.tableAdapterManager.Tb_ConferencesTableAdapter = null;
            this.tableAdapterManager.Tb_CustomersTableAdapter = null;
            this.tableAdapterManager.Tb_expencesTableAdapter = null;
            this.tableAdapterManager.Tb_HotelsTableAdapter = null;
            this.tableAdapterManager.Tb_LoginTableAdapter = null;
            this.tableAdapterManager.Tb_RevinuesTableAdapter = this.tb_RevinuesTableAdapter;
            this.tableAdapterManager.Tb_suppliersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjectVIBES.VibesDataSourcesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tb_RevinuesBindingNavigator
            // 
            this.tb_RevinuesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tb_RevinuesBindingNavigator.BindingSource = this.tb_RevinuesBindingSource;
            this.tb_RevinuesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tb_RevinuesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tb_RevinuesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tb_RevinuesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tb_RevinuesBindingNavigatorSaveItem});
            this.tb_RevinuesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tb_RevinuesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tb_RevinuesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tb_RevinuesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tb_RevinuesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tb_RevinuesBindingNavigator.Name = "tb_RevinuesBindingNavigator";
            this.tb_RevinuesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tb_RevinuesBindingNavigator.Size = new System.Drawing.Size(580, 27);
            this.tb_RevinuesBindingNavigator.TabIndex = 0;
            this.tb_RevinuesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tb_RevinuesBindingNavigatorSaveItem
            // 
            this.tb_RevinuesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_RevinuesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tb_RevinuesBindingNavigatorSaveItem.Image")));
            this.tb_RevinuesBindingNavigatorSaveItem.Name = "tb_RevinuesBindingNavigatorSaveItem";
            this.tb_RevinuesBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.tb_RevinuesBindingNavigatorSaveItem.Text = "Save Data";
            this.tb_RevinuesBindingNavigatorSaveItem.Click += new System.EventHandler(this.tb_RevinuesBindingNavigatorSaveItem_Click);
            // 
            // tb_RevinuesDataGridView
            // 
            this.tb_RevinuesDataGridView.AutoGenerateColumns = false;
            this.tb_RevinuesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_RevinuesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tb_RevinuesDataGridView.DataSource = this.tb_RevinuesBindingSource;
            this.tb_RevinuesDataGridView.Location = new System.Drawing.Point(52, 182);
            this.tb_RevinuesDataGridView.Name = "tb_RevinuesDataGridView";
            this.tb_RevinuesDataGridView.RowTemplate.Height = 24;
            this.tb_RevinuesDataGridView.Size = new System.Drawing.Size(446, 220);
            this.tb_RevinuesDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Note";
            this.dataGridViewTextBoxColumn3.HeaderText = "Note";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_RevinuesBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(160, 57);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(278, 22);
            this.iDTextBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_RevinuesBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(160, 85);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(278, 22);
            this.nameTextBox.TabIndex = 5;
            // 
            // noteTextBox
            // 
            this.noteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_RevinuesBindingSource, "Note", true));
            this.noteTextBox.Location = new System.Drawing.Point(160, 113);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(278, 45);
            this.noteTextBox.TabIndex = 7;
            // 
            // revenuefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 450);
            this.Controls.Add(noteLabel);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(this.tb_RevinuesDataGridView);
            this.Controls.Add(this.tb_RevinuesBindingNavigator);
            this.Name = "revenuefrm";
            this.Text = "revenuefrm";
            this.Load += new System.EventHandler(this.revenuefrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vibesDataSourcesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_RevinuesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_RevinuesBindingNavigator)).EndInit();
            this.tb_RevinuesBindingNavigator.ResumeLayout(false);
            this.tb_RevinuesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_RevinuesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VibesDataSourcesDataSet vibesDataSourcesDataSet;
        private System.Windows.Forms.BindingSource tb_RevinuesBindingSource;
        private VibesDataSourcesDataSetTableAdapters.Tb_RevinuesTableAdapter tb_RevinuesTableAdapter;
        private VibesDataSourcesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tb_RevinuesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tb_RevinuesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tb_RevinuesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox noteTextBox;
    }
}