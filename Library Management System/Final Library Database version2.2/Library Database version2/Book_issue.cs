using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Library_Database_version2
{
    public partial class Book_issue : Form
    {
        public static string loc;
        public static string loc1;
        int bkno = 0;
        private OleDbConnection connection = new OleDbConnection();
        public Book_issue()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Database1.accdb;
           Persist Security Info=False;";
        }

        //search book in libraary
        private void booksearch_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Book_Name")
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
               
                string cp = "SELECT (Book_Id)as [Book_Id],(Book_Name) as [Book_Name],(Author) as [Author],(Location) as [Location],(Edition) as [Edition],(Subject) as [Subject] from book where Book_Name like '%" + textsearch.Text + "%' and Location='lib'order by Book_Name";

                command.CommandText = cp;

                OleDbDataAdapter da1 = new OleDbDataAdapter(command);
                DataTable dt1 = new DataTable();

                da1.Fill(dt1);
                dataGridView2.DataSource = dt1;

                connection.Close();

            }

            if (comboBox1.Text == "Author")
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                

                string cp = "SELECT (Book_Id)as [Book_Id],(Book_Name) as [Book_Name],(Author) as [Author],(Location) as [Location],(Edition) as [Edition],(Subject) as [Subject] from book where Author like '%" + textsearch.Text + "%' and Location='lib'order by Author";
                command.CommandText = cp;


                OleDbDataAdapter da1 = new OleDbDataAdapter(command);
                DataTable dt1 = new DataTable();

                da1.Fill(dt1);
                dataGridView2.DataSource = dt1;


                connection.Close();

            }
          }


        //check student id
        private void studentcheck_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            string cp = "SELECT (Book_Id)as [Book_Id],(Book_Name) as [Book_Name],(Author) as [Author],(Publisher) as [Publisher],(Edition) as [Edition],(Subject) as [Subject] from book where Location like '" + textstudentid.Text + "' order by Book_Name";
         
            loc = textstudentid.Text;
            command.CommandText = cp;

            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridView1.DataSource = dt;




            connection.Close();
             bkno=1;
            foreach (DataRow row in dt.Rows)
            {
                bkno++;
            }
        }



        //issue book

        private void bookissue_Click(object sender, EventArgs e)
        {
            if (bkno > 3)
            {
                MessageBox.Show("Already 3 books are issued.");
                textbookid.Text = String.Empty;
            }

            else
            {

                if (string.IsNullOrEmpty(textbookid.Text))
                {
                    MessageBox.Show("Selection Error.");
                }
                else

                {
                    try
                    {
                        connection.Open();
                        OleDbCommand command = new OleDbCommand();
                        command.Connection = connection;
                        string cb = "UPDATE book SET [Location] = '" + Book_issue.loc + "' WHERE [Book_Id]='" + textbookid.Text + "'";

                        command = new OleDbCommand(cb);

                        command.Connection = connection;
                        command.ExecuteReader();
                        connection.Close();


                        connection.Open();
                        OleDbCommand command1 = new OleDbCommand();
                        command1.Connection = connection;
                        string cq = "INSERT INTO Studentbook(Student_Id,Book_Id,Issue_Date) VALUES (@d1,@d2,@d3)";
                        command1 = new OleDbCommand(cq);

                        command1.Connection = connection;

                        command1.Parameters.Add(new OleDbParameter("@d1", System.Data.OleDb.OleDbType.VarChar, 20, "Student_Id"));
                        command1.Parameters.Add(new OleDbParameter("@d2", System.Data.OleDb.OleDbType.VarChar, 30, "Book_Id"));
                        command1.Parameters.Add(new OleDbParameter("@d3", System.Data.OleDb.OleDbType.Date, 30, "Issue_Date"));
                        command1.Parameters["@d1"].Value = Book_issue.loc;
                        command1.Parameters["@d2"].Value = textbookid.Text;
                        command1.Parameters["@d3"].Value = DateTime.Now.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.GetCultureInfo("en-US"));
                        command1.ExecuteNonQuery();

                        MessageBox.Show("Successfully issued", "Book Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connection.Close();

                        refs();
                        refchk();
                    }
                    catch
                    {
                        MessageBox.Show("Selection Error.");
                    }

                    textbookid.Text = String.Empty;
                    connection.Close();
 
                }
                
            }
            
        }


        //renew book
        private void bookrenew_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textbookid.Text))
            {
                MessageBox.Show("Selection Error.");
            }
            else
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    string cb = "UPDATE Book SET [Location] = '" + Book_issue.loc + "'WHERE [Book_Id]='" + textbookid.Text + "'";
                    command = new OleDbCommand(cb);
                    command.Connection = connection;
                    command.ExecuteReader();

                    connection.Close();

                    delete_records();

                    connection.Open();
                    OleDbCommand command1 = new OleDbCommand();
                    command1.Connection = connection;
                    string cq = "INSERT INTO Studentbook(Student_Id,Book_Id,Issue_Date) VALUES (@d1,@d2,@d3)";
                    command1 = new OleDbCommand(cq);

                    command1.Connection = connection;

                    command1.Parameters.Add(new OleDbParameter("@d1", System.Data.OleDb.OleDbType.VarChar, 20, "Student_Id"));
                    command1.Parameters.Add(new OleDbParameter("@d2", System.Data.OleDb.OleDbType.VarChar, 30, "Book_Id"));
                    command1.Parameters.Add(new OleDbParameter("@d3", System.Data.OleDb.OleDbType.Date, 30, "Issue_Date"));
                    command1.Parameters["@d1"].Value = Book_issue.loc;
                    command1.Parameters["@d2"].Value = textbookid.Text;
                    command1.Parameters["@d3"].Value = DateTime.Now.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.GetCultureInfo("en-US"));
                    command1.ExecuteReader();
                    MessageBox.Show("Successfully renewed", "Book Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();
                }
                catch
                {
                    MessageBox.Show("Selection Error.");
                }
                textbookid.Text = String.Empty;
                connection.Close();
               
            }
        }

        //return book
       private void bookreturn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textbookid.Text))
            {
                MessageBox.Show("Selection Error.");
            }
            else
            {
                try
                {

                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    string cb = "UPDATE book SET [Location] = 'lib' WHERE [Book_Id]='" + textbookid.Text + "'";

                    command = new OleDbCommand(cb);

                    command.Connection = connection;
                    command.ExecuteReader();
                    MessageBox.Show("Successfully returned", "Book Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();


                    delete_records();
                    //MessageBox.Show("Successfully returned", "Book Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    refs();
                    refchk();
                }
                catch
                {
                    MessageBox.Show("Selection Error.");
                }
                textbookid.Text = String.Empty;

                connection.Close();
       
            }
           
           
        }



        private void delete_records()
        {

            try
            {

                int RowsAffected = 0;
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string cq = "delete from Studentbook where Book_Id=@DELETE1;";
                command = new OleDbCommand(cq);
                command.Connection = connection;
                command.Parameters.Add(new OleDbParameter("@DELETE1", System.Data.OleDb.OleDbType.VarChar, 20, "Book_Id"));
                command.Parameters["@DELETE1"].Value = textbookid.Text;
                RowsAffected = command.ExecuteNonQuery();

               // connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        
        
        private void mainmenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Menu mn = new Main_Menu();
            mn.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string bid = dataGridView1.Rows[e.RowIndex].Cells[0].Value + "";
            textbookid.Text = bid;
            
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string bid = dataGridView2.Rows[e.RowIndex].Cells[0].Value + "";
            textbookid.Text = bid;
            
        }

        private void Book_issue_Load(object sender, EventArgs e)
        {

        }

        //kills process
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x10) // WM_CLOSE
            {
                // Process the form closing. Call the base method if required,
                // and return from the function if not.
                // For example:
                var ret = MessageBox.Show("Exit??", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == System.Windows.Forms.DialogResult.No)
                    return;
                else
                {
                    //this.Close();
                    Environment.Exit(1);
                    Application.Exit();


                }
            }
            base.WndProc(ref m);
        }
        //refresh datagridview
        public void refs()
        {
            if (comboBox1.Text == "Book_Name")
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                string cp = "SELECT (Book_Id)as [Book_Id],(Book_Name) as [Book_Name],(Author) as [Author],(Location) as [Location],(Edition) as [Edition],(Subject) as [Subject] from book where Book_Name like '" + textsearch.Text + "%'and Location='lib' order by Book_Name";

                command.CommandText = cp;

                OleDbDataAdapter da1 = new OleDbDataAdapter(command);
                DataTable dt1 = new DataTable();

                da1.Fill(dt1);
                dataGridView2.DataSource = dt1;

                connection.Close();


            }

            if (comboBox1.Text == "Author")
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;


                string cp = "SELECT (Book_Id)as [Book_Id],(Book_Name) as [Book_Name],(Author) as [Author],(Location) as [Location],(Edition) as [Edition],(Subject) as [Subject] from book where Author like '" + textsearch.Text + "%' and Location='lib' order by Author";
                command.CommandText = cp;


                OleDbDataAdapter da1 = new OleDbDataAdapter(command);
                DataTable dt1 = new DataTable();

                da1.Fill(dt1);
                dataGridView2.DataSource = dt1;


                connection.Close();

            }
        
        
        
        }

        public void refchk()
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            string cp = "SELECT (Book_Id)as [Book_Id],(Book_Name) as [Book_Name],(Author) as [Author],(Publisher) as [Publisher],(Edition) as [Edition],(Subject) as [Subject] from book where Location like '" + textstudentid.Text + "' order by Book_Name";

            loc = textstudentid.Text;
            command.CommandText = cp;

            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridView1.DataSource = dt;




            connection.Close();
            bkno = 1;
            foreach (DataRow row in dt.Rows)
            {
                bkno++;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
