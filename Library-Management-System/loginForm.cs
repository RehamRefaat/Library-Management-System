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
    public partial class loginForm : Form
    {
        // LibrarianForm is the constructor for the LibrarianForm class
        public loginForm()
        {
            InitializeComponent();
        }

        // The connection to the database line
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\M bluelap\Documents\Mylibraryrehamdb.mdf;Integrated Security=True;Connect Timeout=30");

        // bunifuThinButton21_Click is a function that is called when the librarian inters his name and password to login
        // it take the data (which the librarian entered it) and check if it exists on the database or not
        // if it exists, then login    otherwise, don't.
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from LibrarianTbl where LibName = '"+UnameTb.Text+"' and LibPassword='"+textBox1.Text+"'",Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                MainForm main = new MainForm();
                main.Show();
            }
            else
            {
                MessageBox.Show("Wrong UserName or Password");
            }
            Con.Close();
        }

        //clear is a function that clears the boxes of username and password
        private void clear(object sender, EventArgs e)
        {
            UnameTb.Text = "";
            //PasswordTb.Text = "";   
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
