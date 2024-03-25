using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slide_show
{
    public partial class Form1 : Form
    {
        List<Bitmap> images = new List<Bitmap>();
        Timer timer = new Timer();
        int np = 0;
        
        public Form1()
        {
            InitializeComponent();
            timer.Interval = 500;
            timer.Tick += next_Click;
        }

        private void next_Click(object sender, EventArgs e)
        {
            NextPicture();
        }

        private void NextPicture()
        {
            if (images.Count == 0) return;
            else
            {
                np++;
                if(np>=images.Count)
                {
                    np = 0;
                }
                pictureBox1.Image = images[np];
            }
        }

        private void bt_open_Click_Click(object sender, EventArgs e)
        {
            ////1
            //foreach ( var item in imageList1.Images)
            //{
            //    Bitmap tmp = new Bitmap((Bitmap)item);
            //    Size pt_size = pictureBox1.Size;
            //    images.Add(new Bitmap(tmp, pt_size));

            //}
            //if (images.Count==0)
            //{
            //    MessageBox.Show("Images not found");
            //}
            //else
            //{
            //    MessageBox.Show("OK");
            //}

            //2 загрузка изображений из выбранной папки
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if(folder.ShowDialog()==DialogResult.OK)
            {
                if(images.Count!=0)
                {
                    foreach (var item in images)
                    {
                        item.Dispose();
                    }
                    images.Clear();
                }
                DirectoryInfo direct = new DirectoryInfo(folder.SelectedPath);
                IEnumerable<FileInfo> files = direct.EnumerateFiles();
                foreach (var item in files)
                {
                    string ex = Path.GetExtension(item.FullName);
                    if (ex == ".bmp" || ex == ".jpg" || ex == ".jpeg" || ex == ".png")
                    {
                        Bitmap pt = new Bitmap(item.FullName);
                        // Size pt_size = pictureBox1.Size;
                        images.Add(new Bitmap(pt, pictureBox1.Size));
                    }
                }
            }
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            if (images.Count == 0) MessageBox.Show("Images not found");
            else timer.Start();
        }

        private void bt_stop_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

      
    }
}
