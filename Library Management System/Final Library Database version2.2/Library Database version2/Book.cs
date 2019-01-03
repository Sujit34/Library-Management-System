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
    public partial class Book : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Book()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Database1.accdb;
           Persist Security Info=False;";
        }
        //update book
        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string cb = "UPDATE book SET [Book_Name]= '" + textbookname.Text + "',[Author]= '" + textauthor.Text + "',[Publisher]= '" + textpublisher.Text + "',[Edition]= '" + textedition.Text + "',[Subject]='" + textsubject.Text + "',[Location]='" +textlocation.Text+ "' WHERE [Book_ID]= '" + textbookid.Text + "'";
                command = new OleDbCommand(cb);
                command.Connection = connection;
                command.ExecuteReader();
                MessageBox.Show("Successfully updated", "Book Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            refreash2();
        }


        //insert book
        private void insert_Click(object sender, EventArgs e)
        {
            if (textbookid.Text == "")
            {
                MessageBox.Show("Please enter Book_ID", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbookid.Focus();
                return;
            }

            if (textbookname.Text == "")
            {
                MessageBox.Show("Please enter Book_Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbookname.Focus();
                return;
            }
            if (textauthor.Text == "")
            {
                MessageBox.Show("Please enter Author", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textauthor.Focus();
                return;
            }
            if (textpublisher.Text == "")
            {
                MessageBox.Show("Please enter Publisher", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textpublisher.Focus();
                return;
            }
            if (textedition.Text == "")
            {
                MessageBox.Show("Please enter Edition", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textedition.Focus();
                return;
            }
            if (textsubject.Text == "")
            {
                MessageBox.Show("Please enter Subject", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textsubject.Focus();
                return;
            }
            if (textlocation.Text == "")
            {
                MessageBox.Show("Please enter Location", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textlocation.Focus();
                return;
            }

            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                string ct = "SELECT Book_Id FROM Book WHERE Book_Id=@find";

                command = new OleDbCommand(ct);
                command.Connection = connection;
                command.Parameters.Add(new OleDbParameter("@find", System.Data.OleDb.OleDbType.VarChar, 20, "Book_Id"));
                command.Parameters["@find"].Value = textbookid.Text;
                OleDbDataReader rdr = command.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Book ID Already Exists", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    if ((rdr != null))
                    {
                        rdr.Close();
                    }

                    connection.Close();

                }
                else
                {
                    string cb = "INSERT INTO Book(Book_Id,Book_Name,Author,Edition,Publisher,Subject,Location) VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7)";

                    command = new OleDbCommand(cb);

                    command.Connection = connection;

                    command.Parameters.Add(new OleDbParameter("@d1", System.Data.OleDb.OleDbType.VarChar, 20, "Book_Id"));
                    command.Parameters.Add(new OleDbParameter("@d2", System.Data.OleDb.OleDbType.VarChar, 30, "Book_Name"));
                    command.Parameters.Add(new OleDbParameter("@d3", System.Data.OleDb.OleDbType.VarChar, 30, "Author"));
                    command.Parameters.Add(new OleDbParameter("@d4", System.Data.OleDb.OleDbType.VarChar, 30, "Edition"));
                    command.Parameters.Add(new OleDbParameter("@d5", System.Data.OleDb.OleDbType.VarChar, 30, "Publisher"));
                    command.Parameters.Add(new OleDbParameter("@d6", System.Data.OleDb.OleDbType.VarChar, 50, "Subject"));
                    command.Parameters.Add(new OleDbParameter("@d7", System.Data.OleDb.OleDbType.VarChar, 30, "Location"));
                    command.Parameters["@d1"].Value = textbookid.Text;
                    command.Parameters["@d2"].Value = textbookname.Text;
                    command.Parameters["@d3"].Value = textauthor.Text;
                    command.Parameters["@d4"].Value = textedition.Text;
                    command.Parameters["@d5"].Value = textpublisher.Text;
                    command.Parameters["@d6"].Value = textsubject.Text;
                    command.Parameters["@d7"].Value = textlocation.Text;


                    command.ExecuteReader();
                    MessageBox.Show("Successfully saved", "Book Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    insert.Enabled = true;
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }


                    connection.Close();
                    connection.Open();
                    string cb1 = "INSERT INTO Admincontrol(User_Id,Book_Id) VALUES (@d1,@d2)";
                    command = new OleDbCommand(cb1);

                    command.Connection = connection;
                    command.Parameters.Add(new OleDbParameter("@d1", System.Data.OleDb.OleDbType.VarChar, 20, "Admin"));
                    command.Parameters.Add(new OleDbParameter("@d2", System.Data.OleDb.OleDbType.VarChar, 30, "Book_Id"));

                    command.Parameters["@d1"].Value = Login.admin;
                    command.Parameters["@d2"].Value = textbookid.Text;

                    command.ExecuteReader();
                    connection.Close();

               
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            refreash2();
        }


        //show all books
        private void allbooks_Click(object sender, EventArgs e)
        {
            connection.Close();

            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
               // string query = " select * from book ORDER BY Book_Id";
                string cp = "SELECT (Book_Id)as [Book_Id],(Book_Name) as [Book_Name],(Author) as [Author],(Publisher)as[Publisher],(Location) as [Location],(Edition) as [Edition],(Subject) as [Subject] from Book order by Book_Id";
                command.CommandText = cp;

                OleDbDataAdapter da1 = new OleDbDataAdapter(command);
                DataTable dt1 = new DataTable();

                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;


                connection.Close();
                this.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //search book icchamoto
        private void search_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Book_Id")
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
               
                string cp = "SELECT (Book_Id)as [Book_Id],(Book_Name) as [Book_Name],(Author) as [Author],(Location) as [Location],(Edition) as [Edition],(Subject) as [Subject] from Book where Book_Id like '" + textsearch.Text + "'order by Book_Id";
                command.CommandText = cp;


                OleDbDataAdapter da1 = new OleDbDataAdapter(command);
                DataTable dt1 = new DataTable();

                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;


                connection.Close();




            }

            if (comboBox1.Text == "Book_Name")
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                
                
                string cp = "SELECT (Book_Id)as [Book_Id],(Book_Name) as [Book_Name],(Author) as [Author],(Publisher)as[Publisher],(Location) as [Location],(Edition) as [Edition],(Subject) as [Subject] from Book where Book_Name like '%" + textsearch.Text + "%'order by Book_Name";
                command.CommandText = cp;


                OleDbDataAdapter da1 = new OleDbDataAdapter(command);
                DataTable dt1 = new DataTable();

                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;


                connection.Close();




            }

            if (comboBox1.Text == "Author")
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                string cp = "SELECT (Book_Id)as [Book_Id],(Book_Name) as [Book_Name],(Author) as [Author],(Publisher)as[Publisher],(Location) as [Location],(Edition) as [Edition],(Subject) as [Subject] from Book where Author like '%" + textsearch.Text + "%'order by Author";

                command.CommandText = cp;


                OleDbDataAdapter da1 = new OleDbDataAdapter(command);
                DataTable dt1 = new DataTable();

                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;


                connection.Close();

            }

            if (comboBox1.Text == "Subject")
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                string cp = "SELECT (Book_Id)as [Book_Id],(Book_Name) as [Book_Name],(Author) as [Author],(Publisher)as[Publisher],(Location) as [Location],(Edition) as [Edition],(Subject) as [Subject] from Book where Subject like '" + textsearch.Text + "'order by book_Id";

                command.CommandText = cp;


                OleDbDataAdapter da1 = new OleDbDataAdapter(command);
                DataTable dt1 = new DataTable();

                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;


                connection.Close();

            }

        }

        //delete book record
        private void delete_Click(object sender, EventArgs e)
        {
            try
            {


                if (MessageBox.Show("Do you really want to delete the record?", "Book Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                {
                    delete_records();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            refreash2();
        }

        //delete function
        private void delete_records()
        {

            try
            {

                int RowsAffected = 0;
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string cq = "delete from Book where Book_Id=@DELETE1;";
                command = new OleDbCommand(cq);
                command.Connection = connection;
                command.Parameters.Add(new OleDbParameter("@DELETE1", System.Data.OleDb.OleDbType.VarChar, 20, "Book_Id"));
                command.Parameters["@DELETE1"].Value = textbookid.Text;
                RowsAffected = command.ExecuteNonQuery();

                if (RowsAffected > 0)
                {
                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //fill textbox by clicking
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
           /* DataGridViewCell cel = null;
            foreach (DataGridViewCell selectedCell in dataGridView1.SelectedCells)
            {
                cel = selectedCell;
                break;

            }
            if (cel != null) //find out row
            {

                DataGridViewRow row = cel.OwningRow;         
                  
                    textbookid.Text = row.Cells[0].Value.ToString();
                    textbookname.Text = row.Cells[1].Value.ToString();
                    textauthor.Text = row.Cells[2].Value.ToString();
                    textpublisher.Text = row.Cells[3].Value.ToString();
                    textlocation.Text = row.Cells[4].Value.ToString();
                    textedition.Text = row.Cells[5].Value.ToString();
                    textsubject.Text = row.Cells[6].Value.ToString();                                   

            }*/
        }

        //go bak main_menu
        private void mainmenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Menu mn = new Main_Menu();
            mn.Show();
        }

        /// <summary>
        /// initially shows all books
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Book_Load(object sender, EventArgs e)
        {
            connection.Close();

            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                // string query = " select * from book ORDER BY Book_Id";
                string cp = "SELECT (Book_Id)as [Book_Id],(Book_Name) as [Book_Name],(Author) as [Author],(Publisher)as[Publisher],(Location) as [Location],(Edition) as [Edition],(Subject) as [Subject] from Book order by Book_Id";
                command.CommandText = cp;

                OleDbDataAdapter da1 = new OleDbDataAdapter(command);
                DataTable dt1 = new DataTable();

                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;


                connection.Close();
                this.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        public void refreash2()
        {
            connection.Close();

            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                // string query = " select * from book ORDER BY Book_Id";
                string cp = "SELECT (Book_Id)as [Book_Id],(Book_Name) as [Book_Name],(Author) as [Author],(Publisher)as[Publisher],(Location) as [Location],(Edition) as [Edition],(Subject) as [Subject] from Book order by Book_Id";
                command.CommandText = cp;

                OleDbDataAdapter da1 = new OleDbDataAdapter(command);
                DataTable dt1 = new DataTable();

                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;


                connection.Close();
                this.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cel = null;
            foreach (DataGridViewCell selectedCell in dataGridView1.SelectedCells)
            {
                cel = selectedCell;
                break;

            }
            if (cel != null) //find out row
            {

                DataGridViewRow row = cel.OwningRow;

                textbookid.Text = row.Cells[0].Value.ToString();
                textbookname.Text = row.Cells[1].Value.ToString();
                textauthor.Text = row.Cells[2].Value.ToString();
                textpublisher.Text = row.Cells[3].Value.ToString();
                textlocation.Text = row.Cells[4].Value.ToString();
                textedition.Text = row.Cells[5].Value.ToString();
                textsubject.Text = row.Cells[6].Value.ToString();

            }
        }
    }
}
