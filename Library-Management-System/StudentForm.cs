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
    public partial class StudentForm : Form
    {
        // StudentForm is the constructor for the StudentForm class
        public StudentForm()
        {
            InitializeComponent();
        }

        // The connection to the database line
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\M bluelap\Documents\Mylibraryrehamdb.mdf;Integrated Security=True;Connect Timeout=30");

        // pictureBox1_Click is a function used for a picture
        //private void pictureBox1_Click(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}

        // Populate is a function that is used to load the components of the table of database into the form when the form is loading
        public void Populate()
        {
            Con.Open();
            string query = "Select * From StudentTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            StudentDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        // FromStudentToMainForm is a function that is connected to the Home button that opens the main form
        private void FromStudentToMainForm(object sender, EventArgs e)
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

        // DeleteStudent is a function that is connected to the Delete button that delets a record from the student table in the database
        private void DeleteStudent(object sender, EventArgs e)
        {
            if (StdId.Text == "")
            {
                MessageBox.Show("Enter The Student Id");
            }
            else
            {
                Con.Open();
                string query = $"Delete From StudentTbl Where StdId = {StdId.Text};";
                SqlCommand cmd = new SqlCommand(query, Con);
                int x = cmd.ExecuteNonQuery();
                if (x==1)
                {
                MessageBox.Show("Student Successfully Deleted");
                }
                Con.Close();
                Populate();
            }
        }

        // StudentForm_Load is a function that is called when the form is loading
        private void StudentForm_Load(object sender, EventArgs e)
        {
            Populate();
        }

        // AddStudent is a function that is connected to the Add button that adds a record to the student table in the database
        private void AddStudent(object sender, EventArgs e)
        {
            if (StdId.Text == "" || StdName.Text == "" || StdSemester.Text == "" || StdPhone.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand($"Insert Into StudentTbl Values ({StdId.Text},'{StdName.Text}','{StdDep.Text}','{StdSemester.SelectedItem.ToString()}','{StdPhone.Text}')", Con);
                    int x = cmd.ExecuteNonQuery();
                    if (x == 1)
                    {
                        MessageBox.Show("Student Added Successfally");
                    }
                    Con.Close();
                    Populate();
                }
                catch 
                {
                    MessageBox.Show("The Student ID Already Exist !");
                    
                }
               
            }
        }

        //بتخليني احط الكلام اللي في الداتبيز جوه المساحه بتعته في البوتن
        // StudentDGV_CellContentClick is a function that works when the user presses on a row on the table 
        // It takes the values in the table, converts them to strings, and puts them in the boxes assigned to them in front of the user
        private void StudentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StdId.Text = StudentDGV.SelectedRows[0].Cells[0].Value.ToString();
            StdName.Text = StudentDGV.SelectedRows[0].Cells[1].Value.ToString();
            StdDep.Text = StudentDGV.SelectedRows[0].Cells[2].Value.ToString();
            StdSemester.SelectedItem= StudentDGV.SelectedRows[0].Cells[3].Value.ToString();
            StdPhone.Text = StudentDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        // EditStudent is a function for the edit button that change the values of the student's id , name , etc...
        private void EditStudent(object sender, EventArgs e)
        {
            if (StdId.Text == "" || StdName.Text == "" || StdSemester.Text == "" || StdPhone.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                Con.Open();
                string query = $"update StudentTbl set StdName='{StdName.Text}',StdDep='{StdDep.Text}',Semester='{StdSemester.SelectedItem.ToString()}',StdPhone='{StdPhone.Text}' Where StdId = {StdId.Text};";
                SqlCommand cmd = new SqlCommand(query, Con);
                int x=cmd.ExecuteNonQuery();
                if(x==1)
                {
                    MessageBox.Show("Student Successfully Updated");
                }
                Con.Close();
                Populate();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StdSemester_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
