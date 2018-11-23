using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
namespace ProjectVIBES
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (customer ctu = new customer())
            {
                if(ctu.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void sourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmSources frm = new frmSources())
            {
                frm.ShowDialog();
            }
        }

        private void hotelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmHotles frm = new frmHotles())
            {
                frm.ShowDialog();
            }
        }

        private void conferebcesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmconferenace frm = new frmconferenace())
            {
                frm.ShowDialog();
            }
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Supplierfrm frm = new Supplierfrm())
            {
                frm.ShowDialog();
            }
        }

        private void expencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (expensefrm frm = new expensefrm())
            {
                frm.ShowDialog();

            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void aznRavToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void invoiceCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmInvoice frm = new frmInvoice())
            {
                frm.ShowDialog();
            }
        }
    }
}
