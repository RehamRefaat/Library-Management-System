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
    public partial class LibrarianForm : Form
    {
        // The connection to the database line
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\M bluelap\Documents\Mylibraryrehamdb.mdf;Integrated Security=True;Connect Timeout=30");

        // LibrarianForm is the constructor for the LibrarianForm class
        public LibrarianForm()
        {
            InitializeComponent();
        }

        // LibrarianForm_Load is a function that is called when the form is loading
        private void LibrarianForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mylibrarydbDataSet.LibrarianTbl' table. You can move, or remove it, as needed.
            this.librarianTblTableAdapter.Fill(this.mylibrarydbDataSet.LibrarianTbl);
            Populate();
        }

        // Populate is a function that is used to load the components of the table of database into the form when the form is loading
        public void Populate()
        {
            Con.Open();
            string query = "Select * From LibrarianTbl";
            SqlDataAdapter da = new SqlDataAdapter(query,Con);
       
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            LibrarianDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        // AddLibrarian is a function that is connected to the Add button that adds a record to the librarian table in the database
        private void AddLibrarian(object sender, EventArgs e)
        {
            if(LibId.Text==""||LibName.Text==""||LibPassword.Text==""||LibPhone.Text=="")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {


                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand($"Insert Into LibrarianTbl Values ({LibId.Text},'{LibName.Text}','{LibPassword.Text}','{LibPhone.Text}')", Con);
                    int x = cmd.ExecuteNonQuery();
                    if (x == 1)
                    {
                        MessageBox.Show("Librarian Added Successfally");
                    }
                    Con.Close();
                    Populate();
                }
                catch 
                {
                    MessageBox.Show("The Librarian ID Already Exist !");
                }

              
            }
        }

        // Exit is a function used for closing the form
        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // DeleteLibrarian is a function that is connected to the Delete button that delets a record from the librarian table in the database
        private void DeleteLibrarian(object sender, EventArgs e)
        {
            if(LibId.Text=="")
            {
                MessageBox.Show("Enter The Librarian Id");
            }
            else
            {
                Con.Open();
                string query = $"Delete From LibrarianTbl Where LibId = {LibId.Text};";
                SqlCommand cmd = new SqlCommand(query,Con);
                int x=cmd.ExecuteNonQuery();
                if (x == 1)
                {
                    MessageBox.Show("Librarian Successfully Deleted");
                }
                Con.Close();
                Populate();
            }
        }

        // LibrarianDGV_CellContentClick is a function that works when the user presses on a row on the table 
        // It takes the values from the table, converts them to strings, and puts them in the boxes assigned to them in front of the user
        private void LibrarianDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LibId.Text = LibrarianDGV.SelectedRows[0].Cells[0].Value.ToString();
            LibName.Text= LibrarianDGV.SelectedRows[0].Cells[1].Value.ToString();
            LibPassword.Text = LibrarianDGV.SelectedRows[0].Cells[2].Value.ToString();
            LibPhone.Text = LibrarianDGV.SelectedRows[0].Cells[3].Value.ToString();

        }

        // EditLibrarian is a function for the edit button that change the values of the librarian's id , name , etc...
        private void EditLibrarian(object sender, EventArgs e)
        {
            if (LibId.Text == "" || LibName.Text == "" || LibPassword.Text == "" || LibPhone.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                Con.Open();
                string query = $"update LibrarianTbl set LibName='{LibName.Text}',LibPassword='{LibPassword.Text}',LibPhone='{LibPhone.Text}' Where LibId={LibId.Text};";
                SqlCommand cmd = new SqlCommand(query, Con);
                int x=cmd.ExecuteNonQuery();
                if (x == 1)
                {
                    MessageBox.Show("Librarian Successfully Updated");
                }
                Con.Close();
                Populate();
            }
        }


        // FromLibrarianToMainForm is a function that is connected to the Home button that opens the main form
        private void FromLibrarianToMainForm(object sender, EventArgs e)
        {
            this.Nav(new MainForm());

            //this.Hide();
            //MainForm main = new MainForm();
            //main.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
