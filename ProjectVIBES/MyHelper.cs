using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectVIBES
{
    class MyHelper
    {
        public bool EnableandUnEnableControls(GroupBox box)
        {
            bool controlstatue = false;
            foreach (Control item in box.Controls)
            {
                item.Enabled =! item.Enabled;
                controlstatue = item.Enabled;
            }
            return controlstatue;

        }

        public void EmptyControls(GroupBox box)
        {
            foreach (Control item in box.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
            }

        }


        public double calcutotal(DataGridView view)
        {
            double number = 0;
            foreach (DataGridViewRow item in view.Rows)
            {
                if(item.Cells[5].Value !=null)
                {
                    number += Convert.ToDouble(item.Cells[5].Value);

                }
                
            }
            return number;
        }
        public List<InvoiceDetail> ConvertToList(DataGridView view)
        {
            List<InvoiceDetail> v = new List<InvoiceDetail>();
            foreach (DataGridViewRow item in view.Rows)
            {
                if(item.Cells[0].Value == null 
                    || item.Cells[1].Value == null || 
                    item.Cells[2].Value == null|| 
                    item.Cells[3].Value == null ||
                    item.Cells[4].Value == null ||
                    item.Cells[5].Value == null 
                     )
                {
                    MessageBox.Show("Please Enter the all data","Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    break;
                }
                
                v.Add(new InvoiceDetail()
                {
                    type = item.Cells[0].Value.ToString(),
                    DoctorID = Convert.ToInt32(item.Cells[1].Value),
                    HotelID = Convert.ToInt32(item.Cells[2].Value), 
                    Qtu = Convert.ToInt32(item.Cells[3].Value),
                    price = Convert.ToDecimal(item.Cells[4].Value),
                    Total = Convert.ToDecimal(item.Cells[5].Value)
                    
                });
            }
            return v;
        }

        public void WriteNumbersOnly(GroupBox view)
        {
            foreach (Control item in view.Controls)
            {
               if(item is TextBox)
                {
                    Makeitnumber(item as TextBox);
                }
            }
        }

        private void Makeitnumber(TextBox text)
        {
            text.KeyPress += (sender, e) =>
             {

                 if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                 (e.KeyChar != '.'))
                 {
                     e.Handled = true;
                 }

              
                 if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                 {
                     e.Handled = true;
                 }
             };
           

        }

        
    }
}
