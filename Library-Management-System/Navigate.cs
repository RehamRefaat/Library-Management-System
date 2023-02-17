using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
  static  class Navigate
    {

        public static void Nav(this Form m , Form s)
        {
            s.Show();
            m.Hide();
        }
    }
}
