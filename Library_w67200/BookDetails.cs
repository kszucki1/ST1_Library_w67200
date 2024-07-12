using System;
using System.Windows.Forms;

namespace Library_w67200
{
    public partial class BookDetails : Form
    {
        public BookDetails()
        {
            InitializeComponent();
        }

        private void BookDetails_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DbCon.DbConnectDataSet("SELECT * FROM IRBooks WHERE book_return_date is NULL").Tables[0];
            dataGridView2.DataSource = DbCon.DbConnectDataSet("SELECT * FROM IRBooks WHERE book_return_date is not NULL").Tables[0];
        }
    }
}