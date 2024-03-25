
namespace Slide_show
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_open_Click = new System.Windows.Forms.Button();
            this.bt_start = new System.Windows.Forms.Button();
            this.bt_stop = new System.Windows.Forms.Button();
            this.bt_preview = new System.Windows.Forms.Button();
            this.bt_next = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(44, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(683, 256);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bt_open_Click
            // 
            this.bt_open_Click.Location = new System.Drawing.Point(69, 354);
            this.bt_open_Click.Name = "bt_open_Click";
            this.bt_open_Click.Size = new System.Drawing.Size(75, 23);
            this.bt_open_Click.TabIndex = 1;
            this.bt_open_Click.Text = "open";
            this.bt_open_Click.UseVisualStyleBackColor = true;
            this.bt_open_Click.Click += new System.EventHandler(this.bt_open_Click_Click);
            // 
            // bt_start
            // 
            this.bt_start.Location = new System.Drawing.Point(179, 354);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(75, 23);
            this.bt_start.TabIndex = 2;
            this.bt_start.Text = "start";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // bt_stop
            // 
            this.bt_stop.Location = new System.Drawing.Point(287, 354);
            this.bt_stop.Name = "bt_stop";
            this.bt_stop.Size = new System.Drawing.Size(75, 23);
            this.bt_stop.TabIndex = 3;
            this.bt_stop.Text = "stop";
            this.bt_stop.UseVisualStyleBackColor = true;
            this.bt_stop.Click += new System.EventHandler(this.bt_stop_Click);
            // 
            // bt_preview
            // 
            this.bt_preview.Location = new System.Drawing.Point(402, 354);
            this.bt_preview.Name = "bt_preview";
            this.bt_preview.Size = new System.Drawing.Size(75, 23);
            this.bt_preview.TabIndex = 4;
            this.bt_preview.Text = "preview";
            this.bt_preview.UseVisualStyleBackColor = true;
            // 
            // bt_next
            // 
            this.bt_next.Location = new System.Drawing.Point(527, 354);
            this.bt_next.Name = "bt_next";
            this.bt_next.Size = new System.Drawing.Size(75, 23);
            this.bt_next.TabIndex = 5;
            this.bt_next.Text = "next";
            this.bt_next.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_next);
            this.Controls.Add(this.bt_preview);
            this.Controls.Add(this.bt_stop);
            this.Controls.Add(this.bt_start);
            this.Controls.Add(this.bt_open_Click);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_open_Click;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Button bt_stop;
        private System.Windows.Forms.Button bt_preview;
        private System.Windows.Forms.Button bt_next;
        private System.Windows.Forms.ImageList imageList1;
    }
}

