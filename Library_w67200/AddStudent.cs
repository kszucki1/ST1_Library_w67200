using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Library_w67200
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }
        
        public static bool IsValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
		
            if (string.IsNullOrEmpty(email))
                return false;
		
            Regex regex = new Regex(emailPattern);
            return regex.IsMatch(email);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txtSName.Clear();
            txtEnroll.Clear();
            txtSem.Clear();
            txtContact.Clear();
            txtDep.Clear();
            txtEmail.Clear();
        }
        
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtSName.Text != "" && txtEnroll.Text != "" && txtDep.Text != "" && txtSem.Text != "" &&
                txtContact.Text != "" && txtEmail.Text != "")
            {
                String sname = txtSName.Text;
                String enroll = txtEnroll.Text;
                String dep = txtDep.Text;
                String sem = txtSem.Text;
                String email = txtEmail.Text;
                Int64 contact = Int64.Parse(txtContact.Text);

                if (IsValidEmail(email))
                {
                    DbCon.DbConnect("INSERT INTO NewStudent (sname, enroll, dep, sem, contact, email) VALUES ('" + sname +
                                    "','" + enroll + "','" + dep + "','" + sem + "','" + contact + "','" + email + "')");
                
                    MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSName.Clear();
                    txtEnroll.Clear();
                    txtSem.Clear();
                    txtContact.Clear();
                    txtDep.Clear();
                    txtEmail.Clear();
                }
                else
                {
                    MessageBox.Show("Please enter valid email.", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    txtEmail.Clear();
                }
                
            }
            else
            {
                MessageBox.Show("Please fill every field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}