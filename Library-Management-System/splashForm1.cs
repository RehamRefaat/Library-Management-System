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
    public partial class splashForm1 : Form
    {
        // splashForm1 is the constructor for the LibrarianForm class
        public splashForm1()
        {
            InitializeComponent();
        }

        // splashForm1_Load is a function that is called when the form is loading
        private void splashForm1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }


        int startPoint = 0;

        // timer1_Tick is a function that controles the speed of time that the splash take to be completed
        private void timer1_Tick(object sender, EventArgs e)
        {
            startPoint += 5;
            MyProgress.Value = startPoint;
            if (MyProgress.Value == 100)
            {
                MyProgress.Value = 0;
                timer1.Stop();
                loginForm log = new loginForm();
                log.Show();
                this.Hide();
            }
        }
    }
}
