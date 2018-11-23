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
    public partial class customer : Form
    {
        public customer()
        {
            InitializeComponent();
        }

        private void tb_CustomersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_CustomersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vibesDataSourcesDataSet);

        }

        private void customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vibesDataSourcesDataSet.Tb_Customers' table. You can move, or remove it, as needed.
            this.tb_CustomersTableAdapter.Fill(this.vibesDataSourcesDataSet.Tb_Customers);

        }
    }
}
