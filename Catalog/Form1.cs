using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalog
{
    public partial class Form1 : Form
    {
        Tovar t = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            t = new Tovar();
            Form2 form2 = new Form2(t);
            if(form2.ShowDialog()==DialogResult.OK)
            {
                listBox1.Items.Add(t);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Error");
            }
            else
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(t);
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Error");
            }
            else

            if (form2.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Insert(listBox1.SelectedIndex, t);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);

            }
        }

        // insert и selected index для edit
    }
}
