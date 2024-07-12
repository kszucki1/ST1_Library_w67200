using System.ComponentModel;

namespace Library_w67200
{
    partial class DashboardAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.booksDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Sienna;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.booksToolStripMenuItem, this.studentToolStripMenuItem, this.issueBooksToolStripMenuItem, this.returnBooksToolStripMenuItem, this.booksDetailsToolStripMenuItem, this.raportToolStripMenuItem, this.exitToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(858, 58);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.addBookToolStripMenuItem, this.viewBooksToolStripMenuItem });
            this.booksToolStripMenuItem.Image = global::Library_w67200.Properties.Resources.icons8_books_50;
            this.booksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(101, 54);
            this.booksToolStripMenuItem.Text = "Books";
            // 
            // addBookToolStripMenuItem
            // 
            this.addBookToolStripMenuItem.Image = global::Library_w67200.Properties.Resources.icons8_add_book_48;
            this.addBookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            this.addBookToolStripMenuItem.Size = new System.Drawing.Size(168, 56);
            this.addBookToolStripMenuItem.Text = "Add Book";
            this.addBookToolStripMenuItem.Click += new System.EventHandler(this.addBookToolStripMenuItem_Click);
            // 
            // viewBooksToolStripMenuItem
            // 
            this.viewBooksToolStripMenuItem.Image = global::Library_w67200.Properties.Resources.icons8_book_philosophy_50;
            this.viewBooksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewBooksToolStripMenuItem.Name = "viewBooksToolStripMenuItem";
            this.viewBooksToolStripMenuItem.Size = new System.Drawing.Size(168, 56);
            this.viewBooksToolStripMenuItem.Text = "View Books";
            this.viewBooksToolStripMenuItem.Click += new System.EventHandler(this.viewBooksToolStripMenuItem_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.addStudentToolStripMenuItem, this.viewStudentToolStripMenuItem });
            this.studentToolStripMenuItem.Image = global::Library_w67200.Properties.Resources.icons8_student_male_50;
            this.studentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(110, 54);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.Image = global::Library_w67200.Properties.Resources.icons8_add_user_male_50;
            this.addStudentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(177, 56);
            this.addStudentToolStripMenuItem.Text = "Add Student";
            this.addStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // viewStudentToolStripMenuItem
            // 
            this.viewStudentToolStripMenuItem.Image = global::Library_w67200.Properties.Resources.icons8_view_501;
            this.viewStudentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewStudentToolStripMenuItem.Name = "viewStudentToolStripMenuItem";
            this.viewStudentToolStripMenuItem.Size = new System.Drawing.Size(177, 56);
            this.viewStudentToolStripMenuItem.Text = "View Student";
            this.viewStudentToolStripMenuItem.Click += new System.EventHandler(this.viewStudentToolStripMenuItem_Click);
            // 
            // issueBooksToolStripMenuItem
            // 
            this.issueBooksToolStripMenuItem.Image = global::Library_w67200.Properties.Resources.icons8_book_philosophy_50;
            this.issueBooksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.issueBooksToolStripMenuItem.Name = "issueBooksToolStripMenuItem";
            this.issueBooksToolStripMenuItem.Size = new System.Drawing.Size(130, 54);
            this.issueBooksToolStripMenuItem.Text = "Issue Books";
            this.issueBooksToolStripMenuItem.Click += new System.EventHandler(this.issueBooksToolStripMenuItem_Click);
            // 
            // returnBooksToolStripMenuItem
            // 
            this.returnBooksToolStripMenuItem.Image = global::Library_w67200.Properties.Resources.icons8_return_book_50;
            this.returnBooksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.returnBooksToolStripMenuItem.Name = "returnBooksToolStripMenuItem";
            this.returnBooksToolStripMenuItem.Size = new System.Drawing.Size(139, 54);
            this.returnBooksToolStripMenuItem.Text = "Return Books";
            this.returnBooksToolStripMenuItem.Click += new System.EventHandler(this.returnBooksToolStripMenuItem_Click);
            // 
            // booksDetailsToolStripMenuItem
            // 
            this.booksDetailsToolStripMenuItem.Image = global::Library_w67200.Properties.Resources.icons8_books_50;
            this.booksDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.booksDetailsToolStripMenuItem.Name = "booksDetailsToolStripMenuItem";
            this.booksDetailsToolStripMenuItem.Size = new System.Drawing.Size(139, 54);
            this.booksDetailsToolStripMenuItem.Text = "Books Details";
            this.booksDetailsToolStripMenuItem.Click += new System.EventHandler(this.booksDetailsToolStripMenuItem_Click);
            // 
            // raportToolStripMenuItem
            // 
            this.raportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.toolStripMenuItem1, this.booksToolStripMenuItem1, this.booksDetailToolStripMenuItem });
            this.raportToolStripMenuItem.Image = global::Library_w67200.Properties.Resources._4371224__1_;
            this.raportToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.raportToolStripMenuItem.Name = "raportToolStripMenuItem";
            this.raportToolStripMenuItem.Size = new System.Drawing.Size(104, 54);
            this.raportToolStripMenuItem.Text = "Raport";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.toolStripMenuItem1.Text = "Students";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // booksToolStripMenuItem1
            // 
            this.booksToolStripMenuItem1.Name = "booksToolStripMenuItem1";
            this.booksToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.booksToolStripMenuItem1.Text = "Books";
            this.booksToolStripMenuItem1.Click += new System.EventHandler(this.booksToolStripMenuItem1_Click);
            // 
            // booksDetailToolStripMenuItem
            // 
            this.booksDetailToolStripMenuItem.Name = "booksDetailToolStripMenuItem";
            this.booksDetailToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.booksDetailToolStripMenuItem.Text = "Books Detail";
            this.booksDetailToolStripMenuItem.Click += new System.EventHandler(this.booksDetailToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.Image = global::Library_w67200.Properties.Resources.icons8_exit_sign_50;
            this.exitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(88, 54);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // DashboardAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_w67200.Properties.Resources._72347;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(858, 514);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DashboardAdmin";
            this.Text = "DashboardAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem booksDetailToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem issueBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStudentToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem viewBooksToolStripMenuItem;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBookToolStripMenuItem;

        #endregion
    }
}