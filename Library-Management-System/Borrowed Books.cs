using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class Borrowed_Books : Form
    {
        // Borrowed_Books is the constructor for the Borrowed_Books class
        public Borrowed_Books()
        {
            InitializeComponent();
        }

        // The connection to the database line
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\M bluelap\Documents\Mylibraryrehamdb.mdf;Integrated Security=True;Connect Timeout=30");

        //FillStudent adds the values of the Students ids into the compobox
        private void FillStudent()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select StdId from StudentTbl ", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("StdId", typeof(int));
            dt.Load(rdr);
            StdCb.ValueMember = "StdId";
            StdCb.DataSource = dt;
            Con.Close();
        }
        //FillBook adds the values of the books ids into the compobox
        private void FillBook()
        {
            Con.Open();
            //if the Quantity of a spicified book is equal to 0 , don't add it 
            SqlCommand cmd = new SqlCommand($"select BookName from BookTbl where Quantity>{0}", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("BookName", typeof(string));
            dt.Load(rdr);
            Bookcb.ValueMember = "BookName";
            Bookcb.DataSource = dt;
            Con.Close();
        }
        // Populate is a function that is used to load the components of the table of database into the form when the form is loading
        public void Populate()
        {
            Con.Open();
            string query = "Select * From BorrowedTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            BorroweBookDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
       // fetchstddata gets the students data (student name, student phone number and his section ) from the student table in the database
        private void fetchstddata()
        {
            Con.Open();
            string query = $"select * from StudentTbl where StdId={StdCb.SelectedValue.ToString()}";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                stdnameTb.Text = dr["StdName"].ToString();
                stddpmntTb.Text= dr["StdDep"].ToString();
                PhoneTb.Text= dr["StdPhone"].ToString();
            }
            Con.Close();
        }
        //UpdateBook links the borrowing table with the books table 
        //when a book is borrowed it decrease the number of books (in the books table) by one
        private void UpdateBook()
        {
            int Qty,newQty;
            Con.Open();
            string query = $"select * from BookTbl where BookName='{Bookcb.SelectedValue.ToString()}'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                 Qty = Convert.ToInt32(dr["Quantity"].ToString());
                if (Qty >= 1)
                {
                    newQty = Qty - 1;

                    string query1 = "update BookTbl set Quantity=" + newQty + " where BookName='" + Bookcb.SelectedValue.ToString() + "';";
                    SqlCommand cmd1 = new SqlCommand(query1, Con);

                    cmd1.ExecuteNonQuery();
                }
            }
            Con.Close();
        }
        private void UpdateBookCancellation()
        {
            int Qty, newQty;
              Con.Open();
            string query = $"select * from BookTbl where BookName='{Bookcb.SelectedItem.ToString()}'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Qty = Convert.ToInt32(dr["Quantity"].ToString());
                newQty = Qty + 1;
                string query1 = "update BookTbl set Quantity=" + newQty + " where BookName='" + Bookcb.SelectedItem.ToString() + "';";
                SqlCommand cmd1 = new SqlCommand(query1, Con);
                cmd1.ExecuteNonQuery();
            }
            Con.Close();
        }
        // LibrarianForm_Load is a function that is called when the form is loading
        private void Borrowed_Books_Load(object sender, EventArgs e)
        {
            FillStudent();
            FillBook();
            Populate();
        }

        // FromBorrowedBooksToMainForm is a function that is connected to the Home button that opens the main form
        private void FromBorrowedBooksToMainForm(object sender, EventArgs e)
        {
            this.Nav(new MainForm());
            //this.Hide();
            //MainForm main = new MainForm();
            //main.Show();
        }

        //StdCd_SelectionChangeCommitted is responsible for when we select an student id it takes its data and put it in the form table
        private void StdCd_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchstddata();
        }

        // Borrowe_Book is a function that is connected to the Borrowe button that adds a record to the Borrowed_Books table in the database
        private void Borrowe_Book(object sender, EventArgs e)
        {
            if (BorroweNumTb.Text == "" || stdnameTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                string borrowedate = $"{BorroweDate.Value.Day.ToString()}/{BorroweDate.Value.Month.ToString()}/{BorroweDate.Value.Year.ToString()}";
                Con.Open();
                SqlCommand cmd = new SqlCommand($"Insert Into BorrowedTbl Values ({BorroweNumTb.Text},{StdCb.Text.ToString()},'{stdnameTb.Text}','{stddpmntTb.Text}','{PhoneTb.Text}','{Bookcb.SelectedValue.ToString()}','{borrowedate}')", Con);
                int x=cmd.ExecuteNonQuery();
                if (x == 1)
                {
                    MessageBox.Show("Book Successfally Borrowed ");
                }
                Con.Close();
                UpdateBook();
                Populate();


            }
        }

        // Exit is a function used for closing the form
        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // BorroweBookDGV_CellContentClick is a function that works when the user presses on a row on the table 
        // It takes the values from the table, converts them to strings, and puts them in the boxes assigned to them in front of the user
        private void BorroweBookDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BorroweNumTb.Text =BorroweBookDGV.SelectedRows[0].Cells[0].Value.ToString();
            StdCb.Text = BorroweBookDGV.SelectedRows[0].Cells[1].Value.ToString();
            stdnameTb.Text = BorroweBookDGV.SelectedRows[0].Cells[2].Value.ToString();
            stddpmntTb.Text = BorroweBookDGV.SelectedRows[0].Cells[3].Value.ToString();
            PhoneTb.Text = BorroweBookDGV.SelectedRows[0].Cells[4].Value.ToString();
            Bookcb.Text = BorroweBookDGV.SelectedRows[0].Cells[5].Value.ToString();
        }

        // Borrowe_Cancele is a function that is connected to the Delete button that delets a record from the Borrowed_Books table in the database
        private void Borrowe_Cancele(object sender, EventArgs e)
        {
            if (BorroweNumTb.Text == "")
            {
                MessageBox.Show("Enter The BorroweNumber ");
            }
            else
            {
                Con.Open();
                string query = $"delete from BorrowedTbl where BorrowNum = {BorroweNumTb.Text};";
                SqlCommand cmd = new SqlCommand(query, Con);
                int x=cmd.ExecuteNonQuery();
                if (x==1)
                {
                    MessageBox.Show("Borrowe Successfully Canceled");
                }
                Con.Close();
                 UpdateBookCancellation();
                Populate();
            }
        }

        private void BorroweNumTb_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}

