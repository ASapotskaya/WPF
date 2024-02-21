using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW
{
    public partial class CatalogStart : Form
    {
        Tovar t = null;
        public CatalogStart()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            t = new Tovar();
            CatalogWindow catalogWindow1 = new CatalogWindow(t);
            if (catalogWindow1.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Add(t);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            CatalogWindow catalogWindow1 = new CatalogWindow(t);
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Error");
            }
            else

            if (catalogWindow1.ShowDialog() == DialogResult.OK)
            {

                listBox1.Items.Insert(listBox1.SelectedIndex, t);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
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
    }
}
