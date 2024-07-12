using System;
using System.Data;
using System.Windows.Forms;

namespace Library_w67200
{
    public partial class ReturnBooks : Form
    {
        public ReturnBooks()
        {
            InitializeComponent();
        }

        private String Enroll;
        private String returnDate;
        private int id;
        private int rowid;
        private void button1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void ReturnBooks_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Enroll = txtEnrollSearch.Text;
            DataSet ds = DbCon.DbConnectDataSet("SELECT * FROM IRBooks WHERE std_enroll LIKE '" + Enroll +
                                                "' AND book_return_date is NULL");
            if (ds.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Invalid ID or No book Issued", "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }

            panel3.Visible = true;

            DataSet ds = DbCon.DbConnectDataSet("SELECT * FROM IRBooks WHERE id ='" + id + "'");
            rowid = int.Parse(ds.Tables[0].Rows[0][0].ToString());

            
            txtBookName.Text = ds.Tables[0].Rows[0][7].ToString();
            txtIssueDate.Text = ds.Tables[0].Rows[0][8].ToString(); 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtEnrollSearch.Clear();
            panel3.Visible = false;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Book Will be returned. Continue?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                returnDate = dateTimePicker1.Text;
                Enroll = txtEnrollSearch.Text;
                DbCon.DbConnectDataSet("UPDATE IRBooks SET book_return_date = '" + returnDate + "' WHERE id = '" + id +
                                       "'");

                dataGridView1.DataSource = DbCon.DbConnectDataSet("SELECT * FROM IRBooks WHERE std_enroll LIKE '" + Enroll +
                                                                  "' AND book_return_date is NULL");
            }
        }

        private void txtEnrollSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtEnrollSearch.Text == "")
            {
                panel3.Visible = false;
                dataGridView1.DataSource = null;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtEnrollSearch.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}