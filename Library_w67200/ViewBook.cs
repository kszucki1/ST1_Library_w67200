using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library_w67200
{
    public partial class ViewBook : Form
    {
        
        public ViewBook()
        {
            InitializeComponent();
        }

        private int bid;
        private int rowid;
        private void ViewBook_Load_1(object sender, EventArgs e)
        {
            panel2.Visible = false;
            dataGridView1.DataSource = DbCon.DbConnectDataSet("SELECT * FROM NewBook").Tables[0];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!=null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            
            panel2.Visible = true;

            DataSet ds = DbCon.DbConnectDataSet("SELECT * FROM NewBook WHERE bId ='"+bid+"'");
            rowid = int.Parse(ds.Tables[0].Rows[0][0].ToString());


            txtBookName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtAuthor.Text = ds.Tables[0].Rows[0][2].ToString();
            txtPublication.Text = ds.Tables[0].Rows[0][3].ToString();
            dateTimePicker1.Text = ds.Tables[0].Rows[0][4].ToString();
            txtBookPrice.Text = ds.Tables[0].Rows[0][5].ToString();
            txtBookQuantity.Text = ds.Tables[0].Rows[0][6].ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void txtBookSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtBookSearch.Text != "")
            {
                dataGridView1.DataSource = DbCon.DbConnectDataSet("SELECT * FROM NewBook WHERE bName LIKE '"+txtBookSearch.Text+"%'").Tables[0];
            }
            else
            {
                dataGridView1.DataSource = DbCon.DbConnectDataSet("SELECT * FROM NewBook").Tables[0];
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtBookSearch.Clear();
            panel2.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be updated. Confirm?", "Success", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == DialogResult.OK)
            {
                String bname = txtBookName.Text;
                String author = txtAuthor.Text;
                String publication = txtPublication.Text;
                String date = dateTimePicker1.Text;
                Int64 price = Int64.Parse(txtBookPrice.Text);
                Int64 quantity = Int64.Parse(txtBookQuantity.Text);

                DbCon.DbConnectDataSet("UPDATE NewBook SET bName = '" + bname + "', bAuthor = '" + author + "', bPubl = '" +
                                publication + "', bPDate ='" + date + "', bPrice ='" + price + "',bQuan = '" +
                                quantity +
                                "' WHERE bId ='" + rowid + "'");
                
                dataGridView1.DataSource = DbCon.DbConnectDataSet("SELECT * FROM NewBook").Tables[0];

                String newBookName = txtBookName.Text;
                
                DbCon.DbConnectDataSet("UPDATE IRBooks SET book_name = '"+newBookName+"' WHERE book_name = '"+bname+"'");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be deleted. Confirm?", "Confirmation Dialog", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning) == DialogResult.OK)
            {
               

                DbCon.DbConnectDataSet("DELETE FROM NewBook WHERE bId ='"+rowid+"'");
                
                dataGridView1.DataSource = DbCon.DbConnectDataSet("SELECT * FROM NewBook").Tables[0];
            }
        }
    }
}