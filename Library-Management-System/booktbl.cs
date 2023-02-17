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
    public partial class booktbl : Form
    {
        // The connection to the database line
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\M bluelap\Documents\Mylibraryrehamdb.mdf;Integrated Security=True;Connect Timeout=30");

        // booktbl is the constructor for the booktbl class
        public booktbl()
        {
            InitializeComponent();
        }

        // Populate is a function that is used to load the components of the table of database into the form when the form is loading
        public void Populate()
        {
            Con.Open();
            string query = "Select * From BookTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            BookDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        // booktbl_Load is a function that is called when the form is loading
        private void booktbl_Load(object sender, EventArgs e)
        {
            Populate();
        }

        // AddBook is a function that is connected to the Add button that adds a record to the book table in the database
        private void AddBook(object sender, EventArgs e)
        {
            if (bookname.Text == "" || author.Text == "" || publisher.Text == "" || price.Text == "" || qnt.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {

                Con.Open();
                SqlCommand cmd = new SqlCommand($"insert into BookTbl values ('{bookname.Text}','{author.Text}','{publisher.Text}',{price.Text},{qnt.Text})", Con);
                int x =cmd.ExecuteNonQuery();
                if (x == 1)
                {
                    MessageBox.Show("Book Added Successfally");
                }
                Con.Close();
                Populate();
            }
        }

        // BooktDGV_CellContentClick is a function that works when the user presses on a row on the table 
        // It takes the values in the table, converts them to strings, and puts them in the boxes assigned to them in front of the user
        private void BooktDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bookname.Text = BookDGV.SelectedRows[0].Cells[0].Value.ToString();
            author.Text = BookDGV.SelectedRows[0].Cells[1].Value.ToString();
            publisher.Text = BookDGV.SelectedRows[0].Cells[2].Value.ToString();
            price.Text = BookDGV.SelectedRows[0].Cells[3].Value.ToString();
            qnt.Text = BookDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        // Exit is a function used for closing the form
        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // DeleteBook is a function that is connected to the Delete button that delets a record from the book table in the database
        private void DeleteBook(object sender, EventArgs e)
        {
            if (bookname.Text == "")
            {
                MessageBox.Show("Enter The Book Name");
            }
            else
            {
                Con.Open();
                string query = $"Delete From BookTbl Where BookName = '{bookname.Text}';";
                SqlCommand cmd = new SqlCommand(query, Con);
                int x = cmd.ExecuteNonQuery();
                if (x == 1)
                {
                    MessageBox.Show("Book Successfully Deleted");
                }
                    Con.Close();
                Populate();
            }
        }

        // EditBook is a function for the edit button that change the values of the book's id , name , etc...
        private void EditBook(object sender, EventArgs e)
        {

            if (bookname.Text == "" || author.Text == "" || publisher.Text == "" || price.Text == "" || qnt.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                Con.Open();
                string query = $"update BookTbl set Author='{author.Text}',Publisher='{publisher.Text}',Price={price.Text},Quantity={qnt.Text} Where BookName = '{bookname.Text}';";
                SqlCommand cmd = new SqlCommand(query, Con);
                int x=cmd.ExecuteNonQuery();
                if(x==1)
                {
                    MessageBox.Show("Book Successfully Updated");
                }
                Con.Close();
                Populate();
            }
        }


        // FromBookToMainForm is a function that is connected to the Home button that opens the main form
        private void FromBookToMainForm(object sender, EventArgs e)
        {
            this.Nav(new MainForm());

            //this.Hide();
            //MainForm main = new MainForm();
            //main.Show();
        }

        private void bookname_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
