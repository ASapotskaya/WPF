using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Listview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListBox lb = new ListBox();
            lb.SetBounds(500, 30, 300, 300);
            Controls.Add(lb);
            foreach (ListViewItem item in listView1.Items)
            {
                string text = item.Text;
                foreach (ListViewItem.ListViewSubItem subitem in item.SubItems)
                {
                    text += " :  " + subitem.Text;
                }
                lb.Items.Add(text);
            }
        }
    }
}
