namespace Library_Database_version2
{
    partial class Book_issue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book_issue));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textsearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.booksearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentcheck = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textstudentid = new System.Windows.Forms.TextBox();
            this.bookissue = new System.Windows.Forms.Button();
            this.bookrenew = new System.Windows.Forms.Button();
            this.bookreturn = new System.Windows.Forms.Button();
            this.mainmenu = new System.Windows.Forms.Button();
            this.textbookid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.textsearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.booksearch);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 286);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book info";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Book_Name",
            "Author"});
            this.comboBox1.Location = new System.Drawing.Point(486, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.Location = new System.Drawing.Point(15, 75);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(700, 190);
            this.dataGridView2.TabIndex = 8;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // textsearch
            // 
            this.textsearch.Location = new System.Drawing.Point(486, 44);
            this.textsearch.Name = "textsearch";
            this.textsearch.Size = new System.Drawing.Size(121, 20);
            this.textsearch.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(631, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search by";
            // 
            // booksearch
            // 
            this.booksearch.Location = new System.Drawing.Point(634, 44);
            this.booksearch.Name = "booksearch";
            this.booksearch.Size = new System.Drawing.Size(75, 23);
            this.booksearch.TabIndex = 0;
            this.booksearch.Text = "Search";
            this.booksearch.UseVisualStyleBackColor = true;
            this.booksearch.Click += new System.EventHandler(this.booksearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.studentcheck);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textstudentid);
            this.groupBox2.Location = new System.Drawing.Point(12, 346);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(730, 217);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student info";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(15, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(700, 150);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // studentcheck
            // 
            this.studentcheck.Location = new System.Drawing.Point(634, 28);
            this.studentcheck.Name = "studentcheck";
            this.studentcheck.Size = new System.Drawing.Size(75, 23);
            this.studentcheck.TabIndex = 6;
            this.studentcheck.Text = "check";
            this.studentcheck.UseVisualStyleBackColor = true;
            this.studentcheck.Click += new System.EventHandler(this.studentcheck_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Student id";
            // 
            // textstudentid
            // 
            this.textstudentid.Location = new System.Drawing.Point(486, 28);
            this.textstudentid.Name = "textstudentid";
            this.textstudentid.Size = new System.Drawing.Size(121, 20);
            this.textstudentid.TabIndex = 4;
            // 
            // bookissue
            // 
            this.bookissue.Location = new System.Drawing.Point(267, 627);
            this.bookissue.Name = "bookissue";
            this.bookissue.Size = new System.Drawing.Size(75, 23);
            this.bookissue.TabIndex = 2;
            this.bookissue.Text = "issue";
            this.bookissue.UseVisualStyleBackColor = true;
            this.bookissue.Click += new System.EventHandler(this.bookissue_Click);
            // 
            // bookrenew
            // 
            this.bookrenew.Location = new System.Drawing.Point(375, 630);
            this.bookrenew.Name = "bookrenew";
            this.bookrenew.Size = new System.Drawing.Size(75, 23);
            this.bookrenew.TabIndex = 3;
            this.bookrenew.Text = "renew";
            this.bookrenew.UseVisualStyleBackColor = true;
            this.bookrenew.Click += new System.EventHandler(this.bookrenew_Click);
            // 
            // bookreturn
            // 
            this.bookreturn.Location = new System.Drawing.Point(487, 627);
            this.bookreturn.Name = "bookreturn";
            this.bookreturn.Size = new System.Drawing.Size(75, 23);
            this.bookreturn.TabIndex = 4;
            this.bookreturn.Text = "return";
            this.bookreturn.UseVisualStyleBackColor = true;
            this.bookreturn.Click += new System.EventHandler(this.bookreturn_Click);
            // 
            // mainmenu
            // 
            this.mainmenu.Location = new System.Drawing.Point(646, 627);
            this.mainmenu.Name = "mainmenu";
            this.mainmenu.Size = new System.Drawing.Size(75, 23);
            this.mainmenu.TabIndex = 5;
            this.mainmenu.Text = "Main Menu";
            this.mainmenu.UseVisualStyleBackColor = true;
            this.mainmenu.Click += new System.EventHandler(this.mainmenu_Click);
            // 
            // textbookid
            // 
            this.textbookid.Location = new System.Drawing.Point(109, 627);
            this.textbookid.Name = "textbookid";
            this.textbookid.Size = new System.Drawing.Size(121, 20);
            this.textbookid.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 630);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Book id";
            // 
            // Book_issue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(754, 662);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textbookid);
            this.Controls.Add(this.mainmenu);
            this.Controls.Add(this.bookreturn);
            this.Controls.Add(this.bookrenew);
            this.Controls.Add(this.bookissue);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Book_issue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book_issue";
            this.Load += new System.EventHandler(this.Book_issue_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button booksearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button studentcheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textstudentid;
        private System.Windows.Forms.Button bookissue;
        private System.Windows.Forms.Button bookrenew;
        private System.Windows.Forms.Button bookreturn;
        private System.Windows.Forms.Button mainmenu;
        private System.Windows.Forms.TextBox textbookid;
        private System.Windows.Forms.Label label3;
    }
}