using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        SolidBrush mybrush;
        Graphics my_g;
        bool isDrawing = false;

        private void p_color_DoubleClick(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                p_color.BackColor = colorDialog1.Color;
                mybrush.Color = colorDialog1.Color;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing == true)
            {
                
                my_g.FillEllipse(mybrush, e.X, e.Y, trackBar1.Value, trackBar1.Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (isDrawing == true)
            //{
            //    mybrush = new SolidBrush(p_color.BackColor);
            //    my_g.FillEllipse(mybrush.Color = BackColor, e.X, e.Y, trackBar1.Value, trackBar1.Value);
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            mybrush = new SolidBrush(p_color.BackColor);
            my_g = p_color.CreateGraphics();
        }
    }
}

    