using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_my
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                if (!listBox1.Items.Contains(textBox1.Text))
                {
                    listBox1.Items.Add(textBox1.Text);
                    textBox1.Text = "";
                }
                else MessageBox.Show("Error1");
            }
            else MessageBox.Show("Error2");
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            if(listBox1.Items.Count!=0)
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    listBox2.Items.Add(listBox1.Items[i]);
                }
            }
            else MessageBox.Show("Listbox1 is empty");
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0)
            {
                if (listBox1.SelectedItems != null)
                {
                    while (listBox1.SelectedItems.Count>0)
                    {
                        listBox1.Items.Remove(listBox1.SelectedItems[0]);
                    }
                    
                }
               else MessageBox.Show("item is empty");
            }
            else MessageBox.Show("List is empty");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
