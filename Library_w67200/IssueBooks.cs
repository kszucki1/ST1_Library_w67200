using System;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.Security.AccessControl;
using System.Threading;
using System.Windows.Forms;

namespace Library_w67200
{
    public partial class IssueBooks : Form
    {
        public IssueBooks()
        {
            InitializeComponent();
        }

        private int count;
        private void IssueBooks_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString =
                "data source = KACPER\\SQLEXPRESS; database = Library_w67200; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd = new SqlCommand("SELECT bname FROM NewBook", con);
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    comboBox1.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
            con.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtEnrollSearch.Text != "")
            {
                String eid = txtEnrollSearch.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString =
                    "data source = KACPER\\SQLEXPRESS; database = Library_w67200; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                
                cmd.CommandText = "SELECT * FROM NewStudent WHERE enroll = '"+eid+"'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                //Code to count how many book has been issued on this enrollment number
                cmd.CommandText = "SELECT COUNT(std_enroll) FROM IRBooks WHERE std_enroll = '" + eid +
                                  "' and book_return_date is NULL";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                
                count = int.Parse(dataSet.Tables[0].Rows[0][0].ToString());

                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtSName.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtDep.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtSem.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtContact.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtEmail.Text = ds.Tables[0].Rows[0][6].ToString();
                }
                else
                {
                    txtEnrollSearch.Clear();
                    txtSName.Clear();
                    txtContact.Clear();
                    txtDep.Clear();
                    txtEmail.Clear();
                    txtSem.Clear();
                    comboBox1.Text = "";
                    MessageBox.Show("Incorrect Enrollment no", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                txtSName.Clear();
                txtContact.Clear();
                txtDep.Clear();
                txtEmail.Clear();
                txtSem.Clear();
                comboBox1.Text = "";
                MessageBox.Show("Data is invalid. No Student found.", "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtEnrollSearch.Clear();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (txtContact.Text != "" & txtSName.Text != "" & txtDep.Text != "" & txtEmail.Text != "" &
                txtSem.Text != "" & comboBox1.Text != "" & dateTimePicker1.Text != "") 
            {
                if (comboBox1.SelectedIndex != -1 && count <= 2)
                {
                    Console.WriteLine(count);
                    String Sname = txtSName.Text;
                    Int64  Contact = Int64.Parse(txtContact.Text);
                    String Enroll = txtEnrollSearch.Text;
                    Console.WriteLine(Sname);
                    String Dep = txtDep.Text;
                    String email = txtEmail.Text;
                    String Sem = txtSem.Text;
                    String BookName = comboBox1.Text;
                    String IssueDate = dateTimePicker1.Text;

                    DbCon.DbConnect(
                        "INSERT INTO IRBooks (std_enroll, std_name, std_dep, std_sem, std_email, std_contact, book_name, book_issue_date) VALUES ('" +
                        Enroll + "', '" + Sname + "','" + Dep + "','" + Sem + "','" + email + "','" + Contact + "','" +
                        BookName + "','" + IssueDate + "')");

                    MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtEnrollSearch.Clear();
                    txtSName.Clear();
                    txtContact.Clear();
                    txtDep.Clear();
                    txtEmail.Clear();
                    txtSem.Clear();
                    comboBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("Student already have maximum amount of issued books", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEnrollSearch.Clear();
                    txtSName.Clear();
                    txtContact.Clear();
                    txtDep.Clear();
                    txtEmail.Clear();
                    txtSem.Clear();
                    comboBox1.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Please enter Enrollment number", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEnrollSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtEnrollSearch.Text == "")
            {
                txtEnrollSearch.Clear();
                txtSName.Clear();
                txtContact.Clear();
                txtDep.Clear();
                txtEmail.Clear();
                txtSem.Clear();
                comboBox1.Text = "";
            }
        }
    }
}