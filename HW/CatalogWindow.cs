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
    public partial class CatalogWindow : Form
    {


        Tovar tmp;
        public CatalogWindow(Tovar tmp)
        {
            InitializeComponent();
            this.tmp = tmp;
        }



       

        private void OK_Click_1(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbCountry.Text == "" || tbCost.Text == "")
            {
                MessageBox.Show("Error");
            }
            else
            {
                tmp.Name = tbName.Text;
                tmp.Country = tbCountry.Text;
                tmp.Price = Convert.ToDouble(tbCost.Text);
                DialogResult = DialogResult.OK;
            }
        }
    }
}

