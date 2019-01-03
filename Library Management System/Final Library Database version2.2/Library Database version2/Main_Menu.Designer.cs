namespace Library_Database_version2
{
    partial class Main_Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.registrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newStudentEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBookEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeAdminPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAnotherAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.search_book_by_student = new System.Windows.Forms.Label();
            this.search_student = new System.Windows.Forms.Label();
            this.search_book = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrationToolStripMenuItem,
            this.issueBookToolStripMenuItem,
            this.databaseToolStripMenuItem,
            this.sendEmailToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 24);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(534, 74);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // registrationToolStripMenuItem
            // 
            this.registrationToolStripMenuItem.AutoSize = false;
            this.registrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newStudentEntryToolStripMenuItem,
            this.newBookEntryToolStripMenuItem});
            this.registrationToolStripMenuItem.Image = global::Library_Database_version2.Properties.Resources.RegistrationIcon;
            this.registrationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.registrationToolStripMenuItem.Name = "registrationToolStripMenuItem";
            this.registrationToolStripMenuItem.Size = new System.Drawing.Size(82, 70);
            this.registrationToolStripMenuItem.Text = "Registration";
            this.registrationToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.registrationToolStripMenuItem.Click += new System.EventHandler(this.registrationToolStripMenuItem_Click);
            // 
            // newStudentEntryToolStripMenuItem
            // 
            this.newStudentEntryToolStripMenuItem.Name = "newStudentEntryToolStripMenuItem";
            this.newStudentEntryToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.newStudentEntryToolStripMenuItem.Text = "New student entry";
            this.newStudentEntryToolStripMenuItem.Click += new System.EventHandler(this.newStudentEntryToolStripMenuItem_Click);
            // 
            // newBookEntryToolStripMenuItem
            // 
            this.newBookEntryToolStripMenuItem.Name = "newBookEntryToolStripMenuItem";
            this.newBookEntryToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.newBookEntryToolStripMenuItem.Text = "New book entry";
            this.newBookEntryToolStripMenuItem.Click += new System.EventHandler(this.newBookEntryToolStripMenuItem_Click);
            // 
            // issueBookToolStripMenuItem
            // 
            this.issueBookToolStripMenuItem.AutoSize = false;
            this.issueBookToolStripMenuItem.Image = global::Library_Database_version2.Properties.Resources.Books_icon;
            this.issueBookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.issueBookToolStripMenuItem.Name = "issueBookToolStripMenuItem";
            this.issueBookToolStripMenuItem.Size = new System.Drawing.Size(91, 70);
            this.issueBookToolStripMenuItem.Text = "Issue Book";
            this.issueBookToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.issueBookToolStripMenuItem.Click += new System.EventHandler(this.issueBookToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.AutoSize = false;
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.bookToolStripMenuItem});
            this.databaseToolStripMenuItem.Image = global::Library_Database_version2.Properties.Resources.data_management_icon;
            this.databaseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(83, 70);
            this.databaseToolStripMenuItem.Text = "Database";
            this.databaseToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.studentToolStripMenuItem.Text = "Student";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.bookToolStripMenuItem.Text = "Book";
            this.bookToolStripMenuItem.Click += new System.EventHandler(this.bookToolStripMenuItem_Click);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Image = global::Library_Database_version2.Properties.Resources._11;
            this.sendEmailToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(77, 70);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            this.sendEmailToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.sendEmailToolStripMenuItem.Click += new System.EventHandler(this.sendEmailToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = global::Library_Database_version2.Properties.Resources.logout1;
            this.logoutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(62, 70);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(534, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeAdminPasswordToolStripMenuItem,
            this.addAnotherAdminToolStripMenuItem,
            this.updateStudentToolStripMenuItem,
            this.updateBookToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // changeAdminPasswordToolStripMenuItem
            // 
            this.changeAdminPasswordToolStripMenuItem.Name = "changeAdminPasswordToolStripMenuItem";
            this.changeAdminPasswordToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.changeAdminPasswordToolStripMenuItem.Text = "Change admin password";
            this.changeAdminPasswordToolStripMenuItem.Click += new System.EventHandler(this.changeAdminPasswordToolStripMenuItem_Click);
            // 
            // addAnotherAdminToolStripMenuItem
            // 
            this.addAnotherAdminToolStripMenuItem.Name = "addAnotherAdminToolStripMenuItem";
            this.addAnotherAdminToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.addAnotherAdminToolStripMenuItem.Text = "Add another admin";
            this.addAnotherAdminToolStripMenuItem.Click += new System.EventHandler(this.addAnotherAdminToolStripMenuItem_Click);
            // 
            // updateStudentToolStripMenuItem
            // 
            this.updateStudentToolStripMenuItem.Name = "updateStudentToolStripMenuItem";
            this.updateStudentToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.updateStudentToolStripMenuItem.Text = "Update student";
            this.updateStudentToolStripMenuItem.Click += new System.EventHandler(this.updateStudentToolStripMenuItem_Click);
            // 
            // updateBookToolStripMenuItem
            // 
            this.updateBookToolStripMenuItem.Name = "updateBookToolStripMenuItem";
            this.updateBookToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.updateBookToolStripMenuItem.Text = "Update book";
            this.updateBookToolStripMenuItem.Click += new System.EventHandler(this.updateBookToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(500, 180);
            this.dataGridView1.TabIndex = 3;
            // 
            // search_book_by_student
            // 
            this.search_book_by_student.AutoSize = true;
            this.search_book_by_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_book_by_student.Location = new System.Drawing.Point(150, 160);
            this.search_book_by_student.Name = "search_book_by_student";
            this.search_book_by_student.Size = new System.Drawing.Size(174, 13);
            this.search_book_by_student.TabIndex = 4;
            this.search_book_by_student.Text = ">> Search book by student id";
            this.search_book_by_student.Click += new System.EventHandler(this.search_book_by_student_Click);
            this.search_book_by_student.MouseEnter += new System.EventHandler(this.search_book_by_student_MouseEnter);
            this.search_book_by_student.MouseLeave += new System.EventHandler(this.search_book_by_student_MouseLeave);
            this.search_book_by_student.MouseHover += new System.EventHandler(this.search_book_by_student_MouseHover);
            // 
            // search_student
            // 
            this.search_student.AutoSize = true;
            this.search_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_student.Location = new System.Drawing.Point(150, 200);
            this.search_student.Name = "search_student";
            this.search_student.Size = new System.Drawing.Size(111, 13);
            this.search_student.TabIndex = 5;
            this.search_student.Text = ">> Search student";
            this.search_student.Click += new System.EventHandler(this.search_student_Click);
            this.search_student.MouseEnter += new System.EventHandler(this.search_student_MouseEnter);
            this.search_student.MouseLeave += new System.EventHandler(this.search_student_MouseLeave);
            // 
            // search_book
            // 
            this.search_book.AutoSize = true;
            this.search_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_book.Location = new System.Drawing.Point(150, 240);
            this.search_book.Name = "search_book";
            this.search_book.Size = new System.Drawing.Size(97, 13);
            this.search_book.TabIndex = 6;
            this.search_book.Text = ">> Search book";
            this.search_book.Click += new System.EventHandler(this.search_book_Click);
            this.search_book.MouseEnter += new System.EventHandler(this.search_book_MouseEnter);
            this.search_book.MouseLeave += new System.EventHandler(this.search_book_MouseLeave);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 332);
            this.Controls.Add(this.search_book);
            this.Controls.Add(this.search_student);
            this.Controls.Add(this.search_book_by_student);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Menu";
            this.Load += new System.EventHandler(this.Main_Menu_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem registrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newStudentEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newBookEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeAdminPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAnotherAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label search_book_by_student;
        private System.Windows.Forms.Label search_student;
        private System.Windows.Forms.Label search_book;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;


    }
}