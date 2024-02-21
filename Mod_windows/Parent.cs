using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




/*
     модальная форма- перехват управления,
     немодальная форма- блокировки не происходит

        parent -> child
        1) конструктор дочерней формы
        2) доп. функция или свойства доч.формы
        3) перегрузить ShowDialog()




 */
namespace Mod_windows
{
    public partial class Parent : Form
    {
        public Parent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //первый вариант
            //Child f2 = new Child(tb_parent.Text);
            //  f2.ShowDialog(); //модальная Форма
            //// MessageBox.Show("Exit program"); 
            ////f2.Show(); //немодальная форма (можно работать в первой форме)
            ////MessageBox.Show("Exit program");



            //второй вариант

            //Child f2 = new Child();
            //f2.TText = tb_parent.Text;
            //f2.ShowDialog();


            //третий вариант

            //Child f2 = new Child();
            //f2.ShowDialog(tb_parent.Text);
        }
    }
}
