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
    public partial class DashBoard : Form
    {
        // DashBoard is the constructor for the DashBoard class
        public DashBoard()
        {
            InitializeComponent();
        }

        // The connection to the database line
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\M bluelap\Documents\Mylibraryrehamdb.mdf;Integrated Security=True;Connect Timeout=30");

        // Exit is a function used for closing the form
        private void Exit(object sender, EventArgs e)
        {
            this.Hide();
        }

        // DashBoard_Load is a function that is called when the form is loading
        private void DashBoard_Load(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter ada1 = new SqlDataAdapter("select count(*) from BookTbl", Con);
            DataTable dt = new DataTable();
            ada1.Fill(dt);
            Booklbl.Text = dt.Rows[0][0].ToString();

            SqlDataAdapter ada2 = new SqlDataAdapter("select count(*) from StudentTbl", Con);
            DataTable dt2 = new DataTable();
            ada2.Fill(dt2);
            Studentlbl.Text = dt2.Rows[0][0].ToString();

            SqlDataAdapter ada3 = new SqlDataAdapter("select count(*) from LibrarianTbl", Con);
            DataTable dt3 = new DataTable();
            ada3.Fill(dt3);
            LibrarianTbl.Text = dt3.Rows[0][0].ToString();

            SqlDataAdapter ada4 = new SqlDataAdapter("select count(*) from BorrowedTbl", Con);
            DataTable dt4 = new DataTable();
            ada4.Fill(dt4);
            BorrowedLbl.Text = dt4.Rows[0][0].ToString();

            SqlDataAdapter ada5 = new SqlDataAdapter("select count(*) from ReturnTbl", Con);
            DataTable dt5 = new DataTable();
            ada5.Fill(dt5);
            ReturnLbl.Text = dt5.Rows[0][0].ToString();
            Con.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
