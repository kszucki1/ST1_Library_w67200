using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;

namespace Library_w67200
{
    public partial class DashboardAdmin : Form
    {
        
        public DashboardAdmin()
        {
            InitializeComponent();
        }
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        
        private void issueBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueBooks ib = new IssueBooks();
            ib.Show();
        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBooks ab = new AddBooks();
            ab.Show();
        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBook vb = new ViewBook();
            vb.Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent ads = new AddStudent();
            ads.Show();
        }

        private void viewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStudent vs = new ViewStudent();
            vs.Show();
        }

        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBooks rb = new ReturnBooks();
            rb.Show();
        }

        private void booksDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookDetails bookDetails = new BookDetails();
            bookDetails.Show();
        }
        

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to export data to CSV?","Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                DbCon.DbExport("SELECT * FROM NewStudent","C:/Users/szuck/RiderProjects/Library_w67200/Library_w67200/Export/Students.csv");
                
                MessageBox.Show("Data saved to: /Users/szuck/RiderProjects/Library_w67200/Library_w67200/Export/",
                    "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void booksToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to export data to CSV?","Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                DbCon.DbExport("SELECT * FROM NewBook","C:/Users/szuck/RiderProjects/Library_w67200/Library_w67200/Export/Books.csv");
                
                MessageBox.Show("Data saved to: /Users/szuck/RiderProjects/Library_w67200/Library_w67200/Export/",
                    "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void booksDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to export data to CSV?","Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                DbCon.DbExport("SELECT * FROM IRBooks","C:/Users/szuck/RiderProjects/Library_w67200/Library_w67200/Export/Details.csv");
                
                MessageBox.Show("Data saved to: /Users/szuck/RiderProjects/Library_w67200/Library_w67200/Export/",
                    "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}