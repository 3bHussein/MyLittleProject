using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

namespace ProjectVIBES
{
    public partial class frmconferenace : Form
    {
        public frmconferenace()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MyHelper helper = new MyHelper();
            if(helper.EnableandUnEnableControls(this.groupBox1))
            {
                helper.EmptyControls(this.groupBox1);
            }
            else
            {
                Add();

            }
        }

        private void Add()
        {
            VibesDataSourceEntities entities = new VibesDataSourceEntities();

            Tb_Conferences tb_Conferences = new Tb_Conferences()
            {
                Name = txtname.Text,
                Persident_of_Conferences = txtpersident.Text,
                from = datefrom.Value,
                to = dateto.Value,
                introdaction = txtinroduced.Text,
                customerid = Convert.ToInt32(comboBox1.SelectedValue),
                hotelid = Convert.ToInt32(comboBox2.SelectedValue),
                Note = txtNote.Text 
            };
            ValidationContext context = new ValidationContext(tb_Conferences);
            List<ValidationResult> list = new List<ValidationResult>();

            if (Validator.TryValidateObject(tb_Conferences, context, list, true))
            {
                entities.Tb_Conferences.Add(tb_Conferences);
            }
            else
            {
                foreach (var item in list)
                {
                    MessageBox.Show(item.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            if (entities.SaveChanges() > 0)
            {
                MessageBox.Show("the Conferance has been added ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SelectData(entities);
            }
        }

        private void frmconferenace_Load(object sender, EventArgs e)
        {
            VibesDataSourceEntities entities = new VibesDataSourceEntities();

            comboBox1.DataSource = entities.Tb_Customers.ToList();
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "CustomerName";

            comboBox2.DataSource = entities.Tb_Hotels.ToList();
            comboBox2.ValueMember = "ID";
            comboBox2.DisplayMember = "Name";

            SelectData(entities);

        }

        private void SelectData(VibesDataSourceEntities entities)
        {
            var select = from i in entities.Tb_Conferences.ToList()
                         select new
                         {
                             i.ID,
                             i.Name
                         ,
                             i.Persident_of_Conferences
                         ,
                             i.@from,
                             i.to
                         ,
                             i.introdaction
                         ,
                             i.Note
                         };

            dataGridView1.DataSource = select.ToList();
            dataGridView1.Columns[0].Visible = false;
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MyHelper helper = new MyHelper();
            if (helper.EnableandUnEnableControls(this.groupBox1))
            {
               
            }
            else
            {
                Tb_Conferences conferences = new Tb_Conferences();
                conferences.ID = int.Parse(labid.Text);
                conferences.Name = txtname.Text;
                conferences.Persident_of_Conferences = txtpersident.Text;
                conferences.from = datefrom.Value ;
                conferences.to = dateto.Value ;
                conferences.introdaction = txtinroduced.Text;
                conferences.Note = txtNote.Text;
                conferences.customerid = Convert.ToInt32(comboBox1.SelectedValue);
                conferences.hotelid = Convert.ToInt32(comboBox2.SelectedValue);

                ValidationContext context = new ValidationContext(conferences);
                List<ValidationResult> list = new List<ValidationResult>();

                if (Validator.TryValidateObject(conferences, context, list, true))
                {
                    VibesDataSourceEntities entities = new VibesDataSourceEntities();
                    entities.Entry<Tb_Conferences>(conferences).State = System.Data.Entity.EntityState.Modified;
                  if(entities.SaveChanges()>0)
                    {
                        MessageBox.Show("The conferance has been edited","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        SelectData(entities);
                    }
                }
                else
                {
                    foreach (var item in list)
                    {
                        MessageBox.Show(item.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            
                Tb_Conferences conferences = new Tb_Conferences();
                conferences.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                conferences.Name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                conferences.Persident_of_Conferences = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                conferences.from = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value);
                conferences.to = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value);
                conferences.introdaction = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[6].Value != null)
            {
                conferences.Note = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            }
            labid.Text = conferences.ID.ToString();
                txtname.Text = conferences.Name;
                txtpersident.Text = conferences.Persident_of_Conferences;
                datefrom.Value = conferences.from;
                dateto.Value = conferences.to;
                txtinroduced.Text = conferences.introdaction;
                txtNote.Text = conferences.Note;
          
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(labid.Text))
            {
                MessageBox.Show("Please Select Confereance","Information",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                int ID = int.Parse(labid.Text);
                VibesDataSourceEntities entities = new VibesDataSourceEntities();
                Tb_Conferences conferences =   entities.Tb_Conferences.SingleOrDefault(a => a.ID == ID);
                entities.Tb_Conferences.Remove(conferences);
                if(entities.SaveChanges() > 0)
                {
                    MessageBox.Show("The conferance has been deleted","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    SelectData(entities);
                }
            }
        }
    }
}
