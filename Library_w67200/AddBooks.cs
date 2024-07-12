using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library_w67200
{
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }
        

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBName.Text != "" && txtBauthor.Text != "" && txtBP.Text != "" && txtPrice.Text != "" &&
                txtQuan.Text != "")
            {
                String bname = txtBName.Text;
                String bauthor = txtBauthor.Text;
                String publication = txtBP.Text;
                String pdate = dateTimePicker1.Text;
                Int64 quantity = Int64.Parse(txtQuan.Text);
                Int64 price = Int64.Parse(txtPrice.Text);
                

                DbCon.DbConnect("insert into NewBook (bName,bAuthor,bPubl,bPDate,bPrice,bQuan) values ('" + bname + 
                                "','" + bauthor + "','" + publication + "','" + pdate + "','" + price + "','" +
                                quantity + "')");
                
                
                MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBauthor.Clear();
                txtPrice.Clear();
                txtQuan.Clear();
                txtBName.Clear();
                txtBP.Clear();
            }
            else
            {
                MessageBox.Show("Please fill every field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}