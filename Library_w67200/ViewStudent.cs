using System;
using System.Data;
using System.Windows.Forms;

namespace Library_w67200
{
    public partial class ViewStudent : Form
    {
        public ViewStudent()
        {
            InitializeComponent();
        }

        private int sid;
        private int rowid;
        

        private void ViewStudent_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            dataGridView1.DataSource = DbCon.DbConnectDataSet("SELECT * FROM NewStudent").Tables[0];
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                sid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }

            panel2.Visible = true;

            DataSet ds = DbCon.DbConnectDataSet("SELECT * FROM NewStudent WHERE studid ='" + sid + "'");
            rowid = int.Parse(ds.Tables[0].Rows[0][0].ToString());


            txtSName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtEnroll.Text = ds.Tables[0].Rows[0][2].ToString();
            txtDep.Text = ds.Tables[0].Rows[0][3].ToString();
            txtSem.Text = ds.Tables[0].Rows[0][4].ToString();
            txtContact.Text = ds.Tables[0].Rows[0][5].ToString();
            txtEmail.Text = ds.Tables[0].Rows[0][6].ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtEnrollSearch.Clear();
            panel2.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be saved. Confirm?", "Confirmation Dialog", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String sname = txtSName.Text;
                String enroll = txtEnroll.Text;
                String dep = txtDep.Text;
                String sem = txtSem.Text;
                String email = txtEmail.Text;
                Int64 contact = Int64.Parse(txtContact.Text);

                DbCon.DbConnectDataSet("UPDATE NewStudent SET sname = '" + sname + "', enroll = '" + enroll +
                                       "', dep = '" +
                                       dep + "', sem ='" + sem + "', email ='" + email + "',contact = '" +
                                       contact +
                                       "' WHERE studid ='" + rowid + "'");
                
                
                dataGridView1.DataSource = DbCon.DbConnectDataSet("SELECT * FROM NewStudent").Tables[0];
                String newEnroll = txtEnroll.Text;
                
                DbCon.DbConnectDataSet("UPDATE IRBooks SET std_name = '" + sname + "', std_enroll = '" + newEnroll +
                                       "', std_dep = '" +
                                       dep + "', std_sem ='" + sem + "', std_email ='" + email + "',std_contact = '" +
                                       contact +
                                       "' WHERE std_enroll ='" + enroll + "'");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be deleted. Confirm?", "Confirmation Dialog", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning) == DialogResult.OK)
            {


                DbCon.DbConnectDataSet("DELETE FROM NewStudent WHERE studid ='" + rowid + "'");

                dataGridView1.DataSource = DbCon.DbConnectDataSet("SELECT * FROM NewStudent").Tables[0];
                panel2.Visible = false;
            }
        }

        private void txtEnrollSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtEnrollSearch.Text != "")
            {
                dataGridView1.DataSource = DbCon.DbConnectDataSet("SELECT * FROM NewStudent WHERE enroll LIKE '"+txtEnrollSearch.Text+"%'").Tables[0];
            }
            else
            {
                dataGridView1.DataSource = DbCon.DbConnectDataSet("SELECT * FROM NewStudent").Tables[0];
            }
        }
    }
}