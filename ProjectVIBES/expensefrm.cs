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
    public partial class expensefrm : Form
    {
        public expensefrm()
        {
            InitializeComponent();
        }

        private void tb_expencesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_expencesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vibesDataSourcesDataSet);

        }

        private void expensefrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vibesDataSourcesDataSet.Tb_expences' table. You can move, or remove it, as needed.
            this.tb_expencesTableAdapter.Fill(this.vibesDataSourcesDataSet.Tb_expences);

        }
    }
}
