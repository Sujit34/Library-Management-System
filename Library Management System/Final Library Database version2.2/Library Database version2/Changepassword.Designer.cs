namespace Library_Database_version2
{
    partial class Changepassword
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textconfirmpassword = new System.Windows.Forms.TextBox();
            this.textnewpassword = new System.Windows.Forms.TextBox();
            this.textoldpassword = new System.Windows.Forms.TextBox();
            this.textusername = new System.Windows.Forms.TextBox();
            this.Main_Menu = new System.Windows.Forms.Button();
            this.Change_Password = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textconfirmpassword);
            this.groupBox1.Controls.Add(this.textnewpassword);
            this.groupBox1.Controls.Add(this.textoldpassword);
            this.groupBox1.Controls.Add(this.textusername);
            this.groupBox1.Controls.Add(this.Main_Menu);
            this.groupBox1.Controls.Add(this.Change_Password);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 300);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "change password";
            // 
            // textconfirmpassword
            // 
            this.textconfirmpassword.Location = new System.Drawing.Point(149, 182);
            this.textconfirmpassword.Name = "textconfirmpassword";
            this.textconfirmpassword.Size = new System.Drawing.Size(100, 20);
            this.textconfirmpassword.TabIndex = 10;
            // 
            // textnewpassword
            // 
            this.textnewpassword.Location = new System.Drawing.Point(149, 141);
            this.textnewpassword.Name = "textnewpassword";
            this.textnewpassword.Size = new System.Drawing.Size(100, 20);
            this.textnewpassword.TabIndex = 9;
            // 
            // textoldpassword
            // 
            this.textoldpassword.Location = new System.Drawing.Point(149, 98);
            this.textoldpassword.Name = "textoldpassword";
            this.textoldpassword.Size = new System.Drawing.Size(100, 20);
            this.textoldpassword.TabIndex = 8;
            // 
            // textusername
            // 
            this.textusername.Location = new System.Drawing.Point(149, 54);
            this.textusername.Name = "textusername";
            this.textusername.Size = new System.Drawing.Size(100, 20);
            this.textusername.TabIndex = 7;
            // 
            // Main_Menu
            // 
            this.Main_Menu.Location = new System.Drawing.Point(159, 232);
            this.Main_Menu.Name = "Main_Menu";
            this.Main_Menu.Size = new System.Drawing.Size(75, 38);
            this.Main_Menu.TabIndex = 6;
            this.Main_Menu.Text = "Main_Menu";
            this.Main_Menu.UseVisualStyleBackColor = true;
            this.Main_Menu.Click += new System.EventHandler(this.Main_Menu_Click);
            // 
            // Change_Password
            // 
            this.Change_Password.Location = new System.Drawing.Point(35, 232);
            this.Change_Password.Name = "Change_Password";
            this.Change_Password.Size = new System.Drawing.Size(75, 38);
            this.Change_Password.TabIndex = 5;
            this.Change_Password.Text = "Change Password";
            this.Change_Password.UseVisualStyleBackColor = true;
            this.Change_Password.Click += new System.EventHandler(this.Change_Password_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Old password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "New password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Confirm password";
            // 
            // Changepassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(333, 331);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Changepassword";
            this.Text = "Change password";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textconfirmpassword;
        private System.Windows.Forms.TextBox textnewpassword;
        private System.Windows.Forms.TextBox textoldpassword;
        private System.Windows.Forms.TextBox textusername;
        private System.Windows.Forms.Button Main_Menu;
        private System.Windows.Forms.Button Change_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}