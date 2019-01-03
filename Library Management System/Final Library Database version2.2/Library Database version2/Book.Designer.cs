namespace Library_Database_version2
{
    partial class Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textlocation = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textsubject = new System.Windows.Forms.TextBox();
            this.textedition = new System.Windows.Forms.TextBox();
            this.textpublisher = new System.Windows.Forms.TextBox();
            this.textauthor = new System.Windows.Forms.TextBox();
            this.textbookname = new System.Windows.Forms.TextBox();
            this.textbookid = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textsearch = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.allbooks = new System.Windows.Forms.Button();
            this.mainmenu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textlocation);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textsubject);
            this.groupBox1.Controls.Add(this.textedition);
            this.groupBox1.Controls.Add(this.textpublisher);
            this.groupBox1.Controls.Add(this.textauthor);
            this.groupBox1.Controls.Add(this.textbookname);
            this.groupBox1.Controls.Add(this.textbookid);
            this.groupBox1.Controls.Add(this.delete);
            this.groupBox1.Controls.Add(this.update);
            this.groupBox1.Controls.Add(this.insert);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 541);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book Info";
            // 
            // textlocation
            // 
            this.textlocation.Location = new System.Drawing.Point(41, 428);
            this.textlocation.Name = "textlocation";
            this.textlocation.Size = new System.Drawing.Size(100, 20);
            this.textlocation.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Location";
            // 
            // textsubject
            // 
            this.textsubject.Location = new System.Drawing.Point(41, 366);
            this.textsubject.Name = "textsubject";
            this.textsubject.Size = new System.Drawing.Size(100, 20);
            this.textsubject.TabIndex = 15;
            // 
            // textedition
            // 
            this.textedition.Location = new System.Drawing.Point(41, 305);
            this.textedition.Name = "textedition";
            this.textedition.Size = new System.Drawing.Size(100, 20);
            this.textedition.TabIndex = 14;
            // 
            // textpublisher
            // 
            this.textpublisher.Location = new System.Drawing.Point(41, 246);
            this.textpublisher.Name = "textpublisher";
            this.textpublisher.Size = new System.Drawing.Size(100, 20);
            this.textpublisher.TabIndex = 13;
            // 
            // textauthor
            // 
            this.textauthor.Location = new System.Drawing.Point(41, 182);
            this.textauthor.Name = "textauthor";
            this.textauthor.Size = new System.Drawing.Size(100, 20);
            this.textauthor.TabIndex = 12;
            // 
            // textbookname
            // 
            this.textbookname.Location = new System.Drawing.Point(41, 117);
            this.textbookname.Name = "textbookname";
            this.textbookname.Size = new System.Drawing.Size(100, 20);
            this.textbookname.TabIndex = 11;
            // 
            // textbookid
            // 
            this.textbookid.Location = new System.Drawing.Point(41, 56);
            this.textbookid.Name = "textbookid";
            this.textbookid.Size = new System.Drawing.Size(100, 20);
            this.textbookid.TabIndex = 10;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(57, 512);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 9;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(57, 483);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 8;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(57, 454);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 23);
            this.insert.TabIndex = 7;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Subject";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Edition";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Publisher";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Author";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Book name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book id";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(745, 68);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 16;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(742, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Search by";
            // 
            // textsearch
            // 
            this.textsearch.Location = new System.Drawing.Point(596, 71);
            this.textsearch.Name = "textsearch";
            this.textsearch.Size = new System.Drawing.Size(121, 20);
            this.textsearch.TabIndex = 18;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Book_Id",
            "Book_Name",
            "Author",
            "Subject"});
            this.comboBox1.Location = new System.Drawing.Point(596, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // allbooks
            // 
            this.allbooks.Location = new System.Drawing.Point(261, 71);
            this.allbooks.Name = "allbooks";
            this.allbooks.Size = new System.Drawing.Size(75, 23);
            this.allbooks.TabIndex = 20;
            this.allbooks.Text = "All books";
            this.allbooks.UseVisualStyleBackColor = true;
            this.allbooks.Click += new System.EventHandler(this.allbooks_Click);
            // 
            // mainmenu
            // 
            this.mainmenu.Location = new System.Drawing.Point(722, 496);
            this.mainmenu.Name = "mainmenu";
            this.mainmenu.Size = new System.Drawing.Size(75, 23);
            this.mainmenu.TabIndex = 21;
            this.mainmenu.Text = "Main Menu";
            this.mainmenu.UseVisualStyleBackColor = true;
            this.mainmenu.Click += new System.EventHandler(this.mainmenu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(240, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(600, 350);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(865, 568);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mainmenu);
            this.Controls.Add(this.allbooks);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textsearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.search);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Book";
            this.Load += new System.EventHandler(this.Book_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textsubject;
        private System.Windows.Forms.TextBox textedition;
        private System.Windows.Forms.TextBox textpublisher;
        private System.Windows.Forms.TextBox textauthor;
        private System.Windows.Forms.TextBox textbookname;
        private System.Windows.Forms.TextBox textbookid;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textsearch;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button allbooks;
        private System.Windows.Forms.Button mainmenu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textlocation;
        private System.Windows.Forms.Label label8;
    }
}