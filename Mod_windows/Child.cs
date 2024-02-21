using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mod_windows
{
    public partial class Child : Form
    {
        // первый вариант
        //public Child(string s)
        //{
        //    InitializeComponent();

        //    tb_child.Text = s;
        //}
        public Child()
        {
          InitializeComponent();   
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        //второй вариант
        //public string TText 
        //{ 
        //    set{ tb_child.Text = value; } 
        //}

        //третий вариант

        public DialogResult ShowDialog(string s)
        {
            tb_child.Text = s;
            return ShowDialog();
        }
    }
}
