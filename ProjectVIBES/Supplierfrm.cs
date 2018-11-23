using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectVIBES
{
    public partial class Supplierfrm : Form
    {
        public Supplierfrm()
        {
            InitializeComponent();
        }

        private void tb_suppliersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_suppliersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vibesDataSourcesDataSet);

        }

        private void Supplierfrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vibesDataSourcesDataSet.Tb_suppliers' table. You can move, or remove it, as needed.
            this.tb_suppliersTableAdapter.Fill(this.vibesDataSourcesDataSet.Tb_suppliers);

        }
    }
}
