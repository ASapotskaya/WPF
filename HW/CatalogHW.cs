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
    public partial class CatalogHW : Form
    {
        public CatalogHW()
        {
            InitializeComponent();
        }

        private void OpenCatalog_Click(object sender, EventArgs e)
        {
            CatalogStart f3 = new CatalogStart();
            f3.ShowDialog();
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
