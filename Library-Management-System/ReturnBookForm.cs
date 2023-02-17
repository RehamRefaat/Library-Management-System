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
    public partial class ReturnBookForm : Form
    {
        // ReturnBookForm is the constructor for the ReturnBookForm class
        public ReturnBookForm()
        {
            InitializeComponent();
        }

        // The connection to the database line
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\M bluelap\Documents\Mylibraryrehamdb.mdf;Integrated Security=True;Connect Timeout=30");

        // Populate is a function that is used to load the components of the Borrowed table of database into the form when the form is loading
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

        // Populatereturn is a function that is used to load the components of the Return table of database into the form when the form is loading
        public void Populatereturn()
        {
            Con.Open();
            string query = "Select * From ReturnTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ReturnedBookDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

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

        // ReturnBookForm_Load is a function that is called when the form is loading
        private void ReturnBookForm_Load(object sender, EventArgs e)
        {
            Populate();
            Populatereturn();
            FillStudent();
            FillBook();
        }

        // BorroweBookDGV_CellContentClick is a function that works when the user presses on a row on the table 
        // It takes the values from the table, converts them to strings, and puts them in the boxes assigned to them in front of the user
        private void BorroweBookDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           ReturnNumTb.Text = BorroweBookDGV.SelectedRows[0].Cells[0].Value.ToString();
            StdCb.Text = BorroweBookDGV.SelectedRows[0].Cells[1].Value.ToString();
            stdnameTb.Text = BorroweBookDGV.SelectedRows[0].Cells[2].Value.ToString();
            stddpmntTb.Text = BorroweBookDGV.SelectedRows[0].Cells[3].Value.ToString();
            PhoneTb.Text = BorroweBookDGV.SelectedRows[0].Cells[4].Value.ToString();
            Bookcb.Text = BorroweBookDGV.SelectedRows[0].Cells[5].Value.ToString();
        }

        //UpdateBook links the returning table with the books table 
        //when a book is returned it increase the number of books (in the books table) by one
        private void UpdateBook()
        {
            int Qty, newQty;
            Con.Open();
            string query = $"select * from BookTbl where BookName='{Bookcb.Text}'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Qty = Convert.ToInt32(dr["Quantity"].ToString());
                newQty = Qty + 1;
                string query1 = $"update BookTbl set Quantity={newQty} where BookName='{Bookcb.Text}';";
                SqlCommand cmd1 = new SqlCommand(query1, Con);
                cmd1.ExecuteNonQuery();
            }
            Con.Close();
        }

        private void Borrowe_Cancele()
        {
            if (ReturnNumTb.Text == "")
            {
                MessageBox.Show("Enter The BorroweNumber ");
            }
            else
            {
                Con.Open();
                string query = $"delete from BorrowedTbl where BorrowNum = {ReturnNumTb.Text};";
                SqlCommand cmd = new SqlCommand(query, Con);
                //cmd.ExecuteNonQuery();
                int x = cmd.ExecuteNonQuery();
                if (x == 1)
                {
                    MessageBox.Show("Borrowe Successfully Canceled");
                }
                Con.Close();
                //UpdateBookCancellation();
                Populate();
          }
        }

        //Return_Book is a function that is connected to the Return button that adds a record to the Returned_Books table in the database
        private void Return_Book(object sender, EventArgs e)
        {
            if (ReturnNumTb.Text == "" || stdnameTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string borrowedate = $"{BorroweDate.Value.Day.ToString()}/{BorroweDate.Value.Month.ToString()}/{BorroweDate.Value.Year.ToString()}";
                    string returndate = $"{ReturnDate.Value.Day.ToString()}/{BorroweDate.Value.Month.ToString()}/{BorroweDate.Value.Year.ToString()}";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Insert Into ReturnTbl Values (" + ReturnNumTb.Text + "," + StdCb.Text + ",'" + stdnameTb.Text + "','" + stddpmntTb.Text + "','" + PhoneTb.Text + "','" + Bookcb.Text + "','" + borrowedate + "','" + returndate + "')", Con);
                    int x = cmd.ExecuteNonQuery();
                    if (x == 1)
                    {
                        MessageBox.Show("Book Successfally Returned ");
                    }
                    Con.Close();
                    Borrowe_Cancele();
                    UpdateBook();
                    Populate();
                    Populatereturn();
                }
                catch 
                {
                    MessageBox.Show("This book has been returned");
                }
            }
        }

        // FromReturned_BooksToMainForm is a function that is connected to the Home button that opens the main form
        private void FromReturned_BooksToMainForm(object sender, EventArgs e)
        {
            this.Nav(new MainForm());
            //this.Hide();
            //MainForm main = new MainForm();
            //main.Show();
        }

        // pictureBox2_Click is a function used for closing the form
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
        // Bitmap is a class that represents a picture 2D
        // button2_Click it is an event that sayes once the picture is completed --->> print it (as a screanshot of the return form).
        Bitmap bitmap;
        private void button2_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics graphics = panel.CreateGraphics();
            Size size = this.ClientSize;
            bitmap = new Bitmap(size.Width, size.Height, graphics);
            graphics = Graphics.FromImage(bitmap);
            Point point = PointToScreen(panel.Location);
            graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void ReturnNumTb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void ReturnedBookDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
