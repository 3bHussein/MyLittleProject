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
//using MetroFramework.Forms;
using System.Data.Entity.Core.Objects;
using System.Threading;
using System.Data.SqlClient;
namespace ProjectVIBES
{
    public partial class Login : Form
    {
        VibesDataSourceEntities entities = new VibesDataSourceEntities();

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Tb_Login login = entities.Tb_Login.SingleOrDefault(a => a.UserName == textBox1.Text && a.Logpassword == textBox2.Text);
                if (login != null)
                {
                    Thread th = new Thread(() => Application.Run(new Main()));
                    this.Close();
                    th.Start();


                }
                else
                {
                    MessageBox.Show("There is a problem in username and password");
                }
            }
            catch (SqlException sqlex)
            {

                MessageBox.Show("Check The DataBase");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
