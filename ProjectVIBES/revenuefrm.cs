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
    public partial class revenuefrm : Form
    {
        public revenuefrm()
        {
            InitializeComponent();
        }

        private void tb_RevinuesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_RevinuesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vibesDataSourcesDataSet);

        }

        private void revenuefrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vibesDataSourcesDataSet.Tb_Revinues' table. You can move, or remove it, as needed.
            this.tb_RevinuesTableAdapter.Fill(this.vibesDataSourcesDataSet.Tb_Revinues);

        }
    }
}
