
namespace HW
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.EXIT = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 131);
            this.button1.TabIndex = 0;
            this.button1.Text = "Задание 1";
            this.toolTip1.SetToolTip(this.button1, "Координаты мыши");
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(273, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(209, 131);
            this.button2.TabIndex = 1;
            this.button2.Text = "Задание 2";
            this.toolTip2.SetToolTip(this.button2, "Таймер");
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(534, 53);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(212, 131);
            this.button3.TabIndex = 2;
            this.button3.Text = "Задание 3";
            this.toolTip3.SetToolTip(this.button3, "Анкета");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(273, 219);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(209, 127);
            this.button4.TabIndex = 3;
            this.button4.Text = "Задание 4";
            this.toolTip4.SetToolTip(this.button4, "Каталог товаров");
            this.button4.UseVisualStyleBackColor = true;
            // 
            // EXIT
            // 
            this.EXIT.Location = new System.Drawing.Point(171, 388);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(419, 50);
            this.EXIT.TabIndex = 4;
            this.EXIT.Text = "Выход";
            this.EXIT.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Задание 1";
            // 
            // toolTip2
            // 
            this.toolTip2.ToolTipTitle = "Задание 2";
            // 
            // toolTip3
            // 
            this.toolTip3.ToolTipTitle = "Задание 3";
            // 
            // toolTip4
            // 
            this.toolTip4.ToolTipTitle = "Задание 4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EXIT);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
    }
}

