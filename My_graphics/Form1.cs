using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Drawing2D;

namespace My_graphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //6
        //private void Form1_Paint(object sender, PaintEventArgs e)
        //{
        //    Graphics g = e.Graphics;
        //    g.SmoothingMode = System.Drawing.Drawing2D.
        //    SmoothingMode.HighQuality;
        //    g.DrawLine(new Pen(Color.Red, 2), 0, 0, 100, 100);
        //    g.DrawRectangle(new Pen(Color.Green, 2),
        //    new Rectangle(100, 100, 60, 60));
        //    g.DrawPie(new Pen(Color.Indigo, 3), 150, 10, 150, 150,
        //    90, 180);
        //    g.DrawString("Hello GDI + !", new Font("Verdana", 12, FontStyle.Bold), Brushes.Black, 0, 240);
        //    PointF[] pArray = {new PointF(10.0F, 50.0F),
        //         new PointF(200.0F, 200.0F),
        //         new PointF(90.0F, 20.0F),
        //         new PointF(140.0F, 50.0F),
        //         new PointF(40.0F, 150.0F)};
        //    g.DrawPolygon(new Pen(Color.GreenYellow, 2), pArray);
        //    g.DrawEllipse(new Pen(Color.Green, 4), 200, 230, 30, 30);
        //    g.Dispose();
        //}


        //7 brush
        //private void Form1_Paint(object sender, PaintEventArgs e)
        //{
        //    Graphics g = e.Graphics;
        //    Rectangle r1 = new Rectangle(30, 20, 300, 50);
        //    Rectangle r2 = new Rectangle(30, 80, 300, 50);
        //    Rectangle r3 = new Rectangle(30, 140, 300, 50);

        //    //1
        //    LinearGradientBrush lgb = new LinearGradientBrush(r1, Color.Green, Color.Yellow,0.0f,true);
        //    g.FillRectangle(lgb, r1);

        //    //2
        //    HatchBrush hb = new HatchBrush(HatchStyle.Cross, Color.Red);
        //    g.FillRectangle(hb, r2);

        //    //3
        //   // TextureBrush tb = new TextureBrush(new Bitmap("sky2.bpm"));
        //    //g.FillRectangle(tb, r3);
        //    //g.Dispose();
        //}

        //8 region
        //private void Form1_Paint(object sender, PaintEventArgs e)
        //{
        //    Graphics g = e.Graphics;
        //    Rectangle r1 = new Rectangle(30, 20, 140, 140);
        //    Rectangle r2 = new Rectangle(80, 80, 140, 140);
        //    g.DrawRectangle(Pens.Black, r1);
        //    g.DrawRectangle(Pens.Black, r2);
        //    Region reg1 = new Region(r1);
        //    Region reg2 = new Region(r2);
        //    reg1.Union(reg2);
        //    g.FillRegion(Brushes.Blue, reg1);


        //}

        //9
        //private void Form1_Paint(object sender, PaintEventArgs e)
        //{
        //    Graphics g = e.Graphics;
        //    Rectangle r = ClientRectangle;
        //    Image im = new Bitmap("C:\\Users\\Chornogor\\Desktop\\top.png");
        //    g.DrawImage(im, r);
        //    g.Dispose();

        //}
    }
}
