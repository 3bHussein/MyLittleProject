namespace ProjectVIBES
{
    partial class customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customer));
            System.Windows.Forms.Label customerNameLabel;
            System.Windows.Forms.Label typeofCustomerLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label noteLabel;
            this.vibesDataSourcesDataSet = new ProjectVIBES.VibesDataSourcesDataSet();
            this.tb_CustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_CustomersTableAdapter = new ProjectVIBES.VibesDataSourcesDataSetTableAdapters.Tb_CustomersTableAdapter();
            this.tableAdapterManager = new ProjectVIBES.VibesDataSourcesDataSetTableAdapters.TableAdapterManager();
            this.tb_CustomersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tb_CustomersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tb_CustomersDataGridView = new System.Windows.Forms.DataGridView();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.typeofCustomerComboBox = new System.Windows.Forms.ComboBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            customerNameLabel = new System.Windows.Forms.Label();
            typeofCustomerLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            noteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vibesDataSourcesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_CustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_CustomersBindingNavigator)).BeginInit();
            this.tb_CustomersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_CustomersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // vibesDataSourcesDataSet
            // 
            this.vibesDataSourcesDataSet.DataSetName = "VibesDataSourcesDataSet";
            this.vibesDataSourcesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_CustomersBindingSource
            // 
            this.tb_CustomersBindingSource.DataMember = "Tb_Customers";
            this.tb_CustomersBindingSource.DataSource = this.vibesDataSourcesDataSet;
            // 
            // tb_CustomersTableAdapter
            // 
            this.tb_CustomersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Tb_CategoriesTableAdapter = null;
            this.tableAdapterManager.Tb_ConferencesTableAdapter = null;
            this.tableAdapterManager.Tb_CustomersTableAdapter = this.tb_CustomersTableAdapter;
            this.tableAdapterManager.Tb_expencesTableAdapter = null;
            this.tableAdapterManager.Tb_HotelsTableAdapter = null;
            this.tableAdapterManager.Tb_LoginTableAdapter = null;
            this.tableAdapterManager.Tb_RevinuesTableAdapter = null;
            this.tableAdapterManager.Tb_suppliersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjectVIBES.VibesDataSourcesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tb_CustomersBindingNavigator
            // 
            this.tb_CustomersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tb_CustomersBindingNavigator.BindingSource = this.tb_CustomersBindingSource;
            this.tb_CustomersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tb_CustomersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tb_CustomersBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tb_CustomersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tb_CustomersBindingNavigatorSaveItem});
            this.tb_CustomersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tb_CustomersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tb_CustomersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tb_CustomersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tb_CustomersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tb_CustomersBindingNavigator.Name = "tb_CustomersBindingNavigator";
            this.tb_CustomersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tb_CustomersBindingNavigator.Size = new System.Drawing.Size(808, 27);
            this.tb_CustomersBindingNavigator.TabIndex = 0;
            this.tb_CustomersBindingNavigator.Text = "bindingNavigator1";
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
            // tb_CustomersBindingNavigatorSaveItem
            // 
            this.tb_CustomersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_CustomersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tb_CustomersBindingNavigatorSaveItem.Image")));
            this.tb_CustomersBindingNavigatorSaveItem.Name = "tb_CustomersBindingNavigatorSaveItem";
            this.tb_CustomersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tb_CustomersBindingNavigatorSaveItem.Text = "Save Data";
            this.tb_CustomersBindingNavigatorSaveItem.Click += new System.EventHandler(this.tb_CustomersBindingNavigatorSaveItem_Click);
            // 
            // tb_CustomersDataGridView
            // 
            this.tb_CustomersDataGridView.AutoGenerateColumns = false;
            this.tb_CustomersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tb_CustomersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_CustomersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.tb_CustomersDataGridView.DataSource = this.tb_CustomersBindingSource;
            this.tb_CustomersDataGridView.Location = new System.Drawing.Point(12, 290);
            this.tb_CustomersDataGridView.Name = "tb_CustomersDataGridView";
            this.tb_CustomersDataGridView.RowTemplate.Height = 24;
            this.tb_CustomersDataGridView.Size = new System.Drawing.Size(776, 220);
            this.tb_CustomersDataGridView.TabIndex = 1;
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Location = new System.Drawing.Point(26, 67);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new System.Drawing.Size(113, 17);
            customerNameLabel.TabIndex = 2;
            customerNameLabel.Text = "Customer Name:";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_CustomersBindingSource, "CustomerName", true));
            this.customerNameTextBox.Location = new System.Drawing.Point(145, 64);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(209, 22);
            this.customerNameTextBox.TabIndex = 3;
            // 
            // typeofCustomerLabel
            // 
            typeofCustomerLabel.AutoSize = true;
            typeofCustomerLabel.Location = new System.Drawing.Point(19, 110);
            typeofCustomerLabel.Name = "typeofCustomerLabel";
            typeofCustomerLabel.Size = new System.Drawing.Size(120, 17);
            typeofCustomerLabel.TabIndex = 4;
            typeofCustomerLabel.Text = "Typeof Customer:";
            // 
            // typeofCustomerComboBox
            // 
            this.typeofCustomerComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_CustomersBindingSource, "TypeofCustomer", true));
            this.typeofCustomerComboBox.FormattingEnabled = true;
            this.typeofCustomerComboBox.Location = new System.Drawing.Point(145, 107);
            this.typeofCustomerComboBox.Name = "typeofCustomerComboBox";
            this.typeofCustomerComboBox.Size = new System.Drawing.Size(209, 24);
            this.typeofCustomerComboBox.TabIndex = 5;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(76, 153);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(63, 17);
            addressLabel.TabIndex = 6;
            addressLabel.Text = "address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_CustomersBindingSource, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(145, 150);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(209, 22);
            this.addressTextBox.TabIndex = 7;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(87, 190);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(52, 17);
            phoneLabel.TabIndex = 8;
            phoneLabel.Text = "phone:";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_CustomersBindingSource, "phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(145, 187);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(209, 22);
            this.phoneTextBox.TabIndex = 9;
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.Location = new System.Drawing.Point(389, 67);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new System.Drawing.Size(42, 17);
            noteLabel.TabIndex = 10;
            noteLabel.Text = "Note:";
            // 
            // noteTextBox
            // 
            this.noteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_CustomersBindingSource, "Note", true));
            this.noteTextBox.Location = new System.Drawing.Point(437, 64);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(329, 108);
            this.noteTextBox.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CustomerName";
            this.dataGridViewTextBoxColumn6.HeaderText = "CustomerName";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TypeofCustomer";
            this.dataGridViewTextBoxColumn2.HeaderText = "TypeofCustomer";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn3.HeaderText = "address";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "phone";
            this.dataGridViewTextBoxColumn4.HeaderText = "phone";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Note";
            this.dataGridViewTextBoxColumn5.HeaderText = "Note";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 553);
            this.Controls.Add(noteLabel);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(typeofCustomerLabel);
            this.Controls.Add(this.typeofCustomerComboBox);
            this.Controls.Add(customerNameLabel);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.tb_CustomersDataGridView);
            this.Controls.Add(this.tb_CustomersBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "customer";
            this.Load += new System.EventHandler(this.customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vibesDataSourcesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_CustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_CustomersBindingNavigator)).EndInit();
            this.tb_CustomersBindingNavigator.ResumeLayout(false);
            this.tb_CustomersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_CustomersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VibesDataSourcesDataSet vibesDataSourcesDataSet;
        private System.Windows.Forms.BindingSource tb_CustomersBindingSource;
        private VibesDataSourcesDataSetTableAdapters.Tb_CustomersTableAdapter tb_CustomersTableAdapter;
        private VibesDataSourcesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tb_CustomersBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tb_CustomersBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tb_CustomersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.ComboBox typeofCustomerComboBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox noteTextBox;
    }
}