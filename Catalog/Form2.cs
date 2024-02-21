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
    public partial class Form2 : Form
    {

        Tovar tmp;
        public Form2(Tovar tmp)
        {
            InitializeComponent();
            this.tmp = tmp;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {
            if(tbName.Text=="" || tbCountry.Text==""|| tbCost.Text=="")
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
