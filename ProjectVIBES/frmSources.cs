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
    public partial class frmSources : Form
    {
        public frmSources()
        {
            InitializeComponent();
        }

        private void sourcesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sourcesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vibesDataSourcesDataSet);

        }

        private void frmSources_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vibesDataSourcesDataSet.Sources' table. You can move, or remove it, as needed.
            this.sourcesTableAdapter.Fill(this.vibesDataSourcesDataSet.Sources);

        }
    }
}
