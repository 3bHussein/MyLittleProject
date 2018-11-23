namespace ProjectVIBES
{
    partial class frmSources
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSources));
            System.Windows.Forms.Label sourceNameLabel;
            System.Windows.Forms.Label noteLabel;
            this.vibesDataSourcesDataSet = new ProjectVIBES.VibesDataSourcesDataSet();
            this.sourcesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sourcesTableAdapter = new ProjectVIBES.VibesDataSourcesDataSetTableAdapters.SourcesTableAdapter();
            this.tableAdapterManager = new ProjectVIBES.VibesDataSourcesDataSetTableAdapters.TableAdapterManager();
            this.sourcesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.sourcesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sourcesDataGridView = new System.Windows.Forms.DataGridView();
            this.sourceNameTextBox = new System.Windows.Forms.TextBox();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            sourceNameLabel = new System.Windows.Forms.Label();
            noteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vibesDataSourcesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourcesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourcesBindingNavigator)).BeginInit();
            this.sourcesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sourcesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // vibesDataSourcesDataSet
            // 
            this.vibesDataSourcesDataSet.DataSetName = "VibesDataSourcesDataSet";
            this.vibesDataSourcesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sourcesBindingSource
            // 
            this.sourcesBindingSource.DataMember = "Sources";
            this.sourcesBindingSource.DataSource = this.vibesDataSourcesDataSet;
            // 
            // sourcesTableAdapter
            // 
            this.sourcesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.SourcesTableAdapter = this.sourcesTableAdapter;
            this.tableAdapterManager.Tb_CategoriesTableAdapter = null;
            this.tableAdapterManager.Tb_ConferencesTableAdapter = null;
            this.tableAdapterManager.Tb_CustomersTableAdapter = null;
            this.tableAdapterManager.Tb_expencesTableAdapter = null;
            this.tableAdapterManager.Tb_HotelsTableAdapter = null;
            this.tableAdapterManager.Tb_LoginTableAdapter = null;
            this.tableAdapterManager.Tb_RevinuesTableAdapter = null;
            this.tableAdapterManager.Tb_suppliersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjectVIBES.VibesDataSourcesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sourcesBindingNavigator
            // 
            this.sourcesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sourcesBindingNavigator.BindingSource = this.sourcesBindingSource;
            this.sourcesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sourcesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sourcesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sourcesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.sourcesBindingNavigatorSaveItem});
            this.sourcesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sourcesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sourcesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sourcesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sourcesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sourcesBindingNavigator.Name = "sourcesBindingNavigator";
            this.sourcesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sourcesBindingNavigator.Size = new System.Drawing.Size(514, 27);
            this.sourcesBindingNavigator.TabIndex = 0;
            this.sourcesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // sourcesBindingNavigatorSaveItem
            // 
            this.sourcesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sourcesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sourcesBindingNavigatorSaveItem.Image")));
            this.sourcesBindingNavigatorSaveItem.Name = "sourcesBindingNavigatorSaveItem";
            this.sourcesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.sourcesBindingNavigatorSaveItem.Text = "Save Data";
            this.sourcesBindingNavigatorSaveItem.Click += new System.EventHandler(this.sourcesBindingNavigatorSaveItem_Click);
            // 
            // sourcesDataGridView
            // 
            this.sourcesDataGridView.AutoGenerateColumns = false;
            this.sourcesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sourcesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sourcesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.sourcesDataGridView.DataSource = this.sourcesBindingSource;
            this.sourcesDataGridView.Location = new System.Drawing.Point(47, 200);
            this.sourcesDataGridView.Name = "sourcesDataGridView";
            this.sourcesDataGridView.RowTemplate.Height = 24;
            this.sourcesDataGridView.Size = new System.Drawing.Size(421, 220);
            this.sourcesDataGridView.TabIndex = 1;
            // 
            // sourceNameLabel
            // 
            sourceNameLabel.AutoSize = true;
            sourceNameLabel.Location = new System.Drawing.Point(25, 67);
            sourceNameLabel.Name = "sourceNameLabel";
            sourceNameLabel.Size = new System.Drawing.Size(98, 17);
            sourceNameLabel.TabIndex = 2;
            sourceNameLabel.Text = "Source Name:";
            // 
            // sourceNameTextBox
            // 
            this.sourceNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sourcesBindingSource, "SourceName", true));
            this.sourceNameTextBox.Location = new System.Drawing.Point(129, 67);
            this.sourceNameTextBox.Name = "sourceNameTextBox";
            this.sourceNameTextBox.Size = new System.Drawing.Size(329, 22);
            this.sourceNameTextBox.TabIndex = 3;
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.Location = new System.Drawing.Point(81, 109);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new System.Drawing.Size(42, 17);
            noteLabel.TabIndex = 4;
            noteLabel.Text = "Note:";
            // 
            // noteTextBox
            // 
            this.noteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sourcesBindingSource, "Note", true));
            this.noteTextBox.Location = new System.Drawing.Point(129, 106);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(329, 56);
            this.noteTextBox.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SourceName";
            this.dataGridViewTextBoxColumn2.HeaderText = "SourceName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Note";
            this.dataGridViewTextBoxColumn3.HeaderText = "Note";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // frmSources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 450);
            this.Controls.Add(noteLabel);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(sourceNameLabel);
            this.Controls.Add(this.sourceNameTextBox);
            this.Controls.Add(this.sourcesDataGridView);
            this.Controls.Add(this.sourcesBindingNavigator);
            this.Name = "frmSources";
            this.Text = "frmSources";
            this.Load += new System.EventHandler(this.frmSources_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vibesDataSourcesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourcesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourcesBindingNavigator)).EndInit();
            this.sourcesBindingNavigator.ResumeLayout(false);
            this.sourcesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sourcesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VibesDataSourcesDataSet vibesDataSourcesDataSet;
        private System.Windows.Forms.BindingSource sourcesBindingSource;
        private VibesDataSourcesDataSetTableAdapters.SourcesTableAdapter sourcesTableAdapter;
        private VibesDataSourcesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sourcesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton sourcesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView sourcesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox sourceNameTextBox;
        private System.Windows.Forms.TextBox noteTextBox;
    }
}