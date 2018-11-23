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
    public partial class frmHotles : Form
    {
        public frmHotles()
        {
            InitializeComponent();
        }

        private void tb_HotelsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_HotelsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vibesDataSourcesDataSet);

        }

        private void frmHotles_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vibesDataSourcesDataSet.Tb_Hotels' table. You can move, or remove it, as needed.
            this.tb_HotelsTableAdapter.Fill(this.vibesDataSourcesDataSet.Tb_Hotels);

        }
    }
}
