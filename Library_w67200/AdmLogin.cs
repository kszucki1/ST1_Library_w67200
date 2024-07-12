using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Library_w67200
{
    public partial class AdmLogin : Form
    {
        public AdmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void txtUsername_MouseEnter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Clear();
            }
        }
        
        
        private void txtUsername_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Clear();
            }
        }

        private void txtPassword_MouseEnter_1(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Clear();
                txtPassword.PasswordChar = '*';
            }
        }

        private void txtPassword_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Clear();
                txtPassword.PasswordChar = '*';
            }
        }

        private void PicGit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/kszucki");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int adm = 1;
            DataSet ds = DbCon.DbConnectDataSet("SELECT * FROM loginTable where username = '" + txtUsername.Text +
                                                "' and pass ='" +
                                                txtPassword.Text + "' and adm='" + adm + "' ");

            if (ds.Tables[0].Rows.Count != 0)
            {
                this.Hide(); 
                DashboardAdmin dsa = new DashboardAdmin();
                dsa.Show();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGowno_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardAdmin dba = new DashboardAdmin();
            dba.Show();
        }
    }
}
