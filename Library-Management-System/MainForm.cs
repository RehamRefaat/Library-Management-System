using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        // MainForm is the constructor for the LibrarianForm class
        public MainForm()
        {
            InitializeComponent();
        }

        // Exit is a function used for closing the form
        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // OpenStudentForm is a function that is connected to the Students button that opens the StudentForm
        private void OpenStudentForm(object sender, EventArgs e)
        {
            this.Nav(new StudentForm());
            //StudentForm student = new StudentForm();
            //student.Show();
            //this.Hide();
        }

        // OpenBooktblForm is a function that is connected to the Books button that opens the BooktblForm
        private void OpenBooktblForm(object sender, EventArgs e)
        {
            this.Nav(new booktbl());
            //booktbl book = new booktbl();
            //book.Show();
            //this.Hide();
        }

        // OpenLibrarianForm is a function that is connected to the Librarians button that opens the LibrarianForm
        private void OpenLibrarianForm(object sender, EventArgs e)
        {
            this.Nav(new LibrarianForm());
            //LibrarianForm librarian = new LibrarianForm();
            //librarian.Show();
            //this.Hide();
        }

        // OpenBorrowed_BooksForm is a function that is connected to the Borrowe Books button that opens the Borrowed_Books Form
        private void OpenBorrowed_BooksForm(object sender, EventArgs e)
        {
            this.Nav(new Borrowed_Books());
            //Borrowed_Books Borrowe = new Borrowed_Books();
            //Borrowe.Show();
            //this.Hide();

        }

        // OpenReturn_BooksForm is a function that is connected to the Return Books button that opens the ReturnBookForm
        private void OpenReturn_BooksForm(object sender, EventArgs e)
        {
            this.Nav(new ReturnBookForm());
            //ReturnBookForm RetBook = new ReturnBookForm();
            //RetBook.Show();
            //this.Hide();

        }

        // OpenAboutUsForm is a function that is connected to the AboutUs button that opens the AboutUsForm
        private void OpenAboutUsForm(object sender, EventArgs e)
        {
            AboutUs about  = new AboutUs();
            about.Show();
           // this.Hide();
        }

        // OpenDashBoard is a function that is connected to the DashBoard button that opens the DashBoard
        private void OpenDashBoard(object sender, EventArgs e)
        {
            DashBoard board = new DashBoard();
            board.Show();
        }

        // OpenTipsForm is a function that is connected to the Tips button that opens the TipsForm
        private void OpenTipsForm(object sender, EventArgs e)
        {
            TipsForm tips = new TipsForm();
            tips.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
