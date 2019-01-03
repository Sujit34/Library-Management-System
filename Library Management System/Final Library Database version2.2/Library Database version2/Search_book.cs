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
    public partial class Search_book : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Search_book()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Database1.accdb;
           Persist Security Info=False;";
        }


        //book by member id
        private void book_check_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            string cp = "SELECT (Book_Id)as [Book_Id],(Book_Name) as [Book_Name],(Author) as [Author],(Publisher) as [Publisher],(Edition) as [Edition],(Subject) as [Subject] from book where Location like '" + textsearch.Text + "' order by Book_Name";
            command.CommandText = cp;

            OleDbDataAdapter da1 = new OleDbDataAdapter(command);
            DataTable dt1 = new DataTable();

            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;


            connection.Close();
            refr();
        }

        private void fine_Click(object sender, EventArgs e)
        {
            //Fine update

            try
            {
                connection.Open();
                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = connection;

                string cp = "update studentbook SET [Fine]=(DateDiff('d',[Issue_Date], NOW())-30) where DateDiff('d',[Issue_Date], NOW())>30";

                command1.CommandText = cp;
                command1.Connection = connection;
                command1.ExecuteNonQuery();
                connection.Close();

                connection.Open();
                OleDbCommand command2 = new OleDbCommand();
                command2.Connection = connection;

                string cr = "update Studentbook SET [Fine]=0 where DateDiff('d',[Issue_Date], NOW())<30";

                command2.CommandText = cr;
                command2.Connection = connection;
                command2.ExecuteNonQuery();
                connection.Close();


                //show fine
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string cq = "select sum(Fine) from Studentbook where Student_Id='" + textsearch.Text + "'";
                command.CommandText = cq;
                int a = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();
                MessageBox.Show("Your Fine is " + a.ToString() + " BDT", "Fine");
            }
            catch 
            {
                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Student don't borrow any book from library so he has NO FINE");
            }


        }

        //go back main_menu
        private void main_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Menu mn = new Main_Menu();
            mn.Show();
        }

        private void Search_book_Load(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void refr()
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            string cp = "SELECT (Book_Id)as [Book_Id],(Book_Name) as [Book_Name],(Author) as [Author],(Publisher) as [Publisher],(Edition) as [Edition],(Subject) as [Subject] from book where Location like '" + textsearch.Text + "' order by Book_Name";
            command.CommandText = cp;

            OleDbDataAdapter da1 = new OleDbDataAdapter(command);
            DataTable dt1 = new DataTable();

            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;


            connection.Close();
        
        }
    }
}
