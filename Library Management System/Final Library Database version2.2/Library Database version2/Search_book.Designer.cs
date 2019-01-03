namespace Library_Database_version2
{
    partial class Search_book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search_book));
            this.book_check = new System.Windows.Forms.Button();
            this.fine = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textsearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.main_menu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // book_check
            // 
            this.book_check.Location = new System.Drawing.Point(350, 29);
            this.book_check.Name = "book_check";
            this.book_check.Size = new System.Drawing.Size(75, 23);
            this.book_check.TabIndex = 0;
            this.book_check.Text = "Check";
            this.book_check.UseVisualStyleBackColor = true;
            this.book_check.Click += new System.EventHandler(this.book_check_Click);
            // 
            // fine
            // 
            this.fine.Location = new System.Drawing.Point(450, 29);
            this.fine.Name = "fine";
            this.fine.Size = new System.Drawing.Size(75, 23);
            this.fine.TabIndex = 1;
            this.fine.Text = "Fine";
            this.fine.UseVisualStyleBackColor = true;
            this.fine.Click += new System.EventHandler(this.fine_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student id";
            // 
            // textsearch
            // 
            this.textsearch.Location = new System.Drawing.Point(200, 29);
            this.textsearch.Name = "textsearch";
            this.textsearch.Size = new System.Drawing.Size(100, 20);
            this.textsearch.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(650, 220);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // main_menu
            // 
            this.main_menu.Location = new System.Drawing.Point(293, 306);
            this.main_menu.Name = "main_menu";
            this.main_menu.Size = new System.Drawing.Size(75, 23);
            this.main_menu.TabIndex = 5;
            this.main_menu.Text = "Main_Menu";
            this.main_menu.UseVisualStyleBackColor = true;
            this.main_menu.Click += new System.EventHandler(this.main_menu_Click);
            // 
            // Search_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(708, 335);
            this.Controls.Add(this.main_menu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textsearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fine);
            this.Controls.Add(this.book_check);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Search_book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search_book";
            this.Load += new System.EventHandler(this.Search_book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button book_check;
        private System.Windows.Forms.Button fine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textsearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button main_menu;
    }
}