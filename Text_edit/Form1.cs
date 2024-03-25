using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Text_edit
{
    public partial class Form1 : Form
    {
        Color color_my;
        public enum DateTimeFormat { ShowClock,ShowDate};
        DateTimeFormat format;
        public Form1()
        {
            InitializeComponent();
            color_my = BackColor;
            menuStrip_ru.Visible = false;
            button1.Text = "Русский";
            format = DateTimeFormat.ShowClock;
            toolStripStatusLabel2.Click += timer1_Tick;
        }

        

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All files(*.*)|*.*| Text files(*.txt)|*.txt||";
            open.FilterIndex = 1;
            if(open.ShowDialog()==DialogResult.OK)
            {
                StreamReader sr = File.OpenText(open.FileName);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(save.FileName);
                sw.Write(richTextBox1.Text);
                sw.Close();
            }
        }

       

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            if (item.Checked == true)
            {
                this.BackColor = Color.Blue;

            }
            else this.BackColor = color_my;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = richTextBox1.SelectionColor;
            if(cd.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.SelectionColor = cd.Color;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = richTextBox1.SelectionFont;
            if(fontDialog1.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text.CompareTo("Русский")==0)
            {
                button1.Text = "English";
                menuStrip1.Visible = false;
                menuStrip_ru.Visible = true;
                MainMenuStrip = menuStrip_ru;
            }
            else
            {
                button1.Text = "Русский";
                menuStrip1.Visible = true;
                menuStrip_ru.Visible = false;
                MainMenuStrip = menuStrip1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string str;
            str = DateTime.Now.ToShortDateString();
            toolStripStatusLabel2.Text = str;
            str = DateTime.Now.DayOfWeek.ToString();
            toolStripMenuItem15.Text = str;
            if(format ==DateTimeFormat.ShowClock)
            {
                toolStripStatusLabel2.Text = DateTime.Now.ToShortTimeString();
                format = DateTimeFormat.ShowDate;
            }
            else
            {
                toolStripStatusLabel2.Text = DateTime.Now.ToShortDateString();
                format = DateTimeFormat.ShowClock;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void copeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.Text);
        }

        private void pastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += Clipboard.GetText();

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.Text);
            richTextBox1.Text = "";

        }
    }
}
