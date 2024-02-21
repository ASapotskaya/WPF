
namespace HW
{
    partial class CatalogHW
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
            this.OpenCatalog = new System.Windows.Forms.Button();
            this.ExitMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenCatalog
            // 
            this.OpenCatalog.Location = new System.Drawing.Point(0, -3);
            this.OpenCatalog.Name = "OpenCatalog";
            this.OpenCatalog.Size = new System.Drawing.Size(249, 241);
            this.OpenCatalog.TabIndex = 0;
            this.OpenCatalog.Text = "Открыть каталог";
            this.OpenCatalog.UseVisualStyleBackColor = true;
            this.OpenCatalog.Click += new System.EventHandler(this.OpenCatalog_Click);
            // 
            // ExitMenu
            // 
            this.ExitMenu.Location = new System.Drawing.Point(279, -3);
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(249, 241);
            this.ExitMenu.TabIndex = 1;
            this.ExitMenu.Text = "Вернуться в меню";
            this.ExitMenu.UseVisualStyleBackColor = true;
            this.ExitMenu.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // CatalogHW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 237);
            this.Controls.Add(this.ExitMenu);
            this.Controls.Add(this.OpenCatalog);
            this.Name = "CatalogHW";
            this.Text = "CatalogHW";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenCatalog;
        private System.Windows.Forms.Button ExitMenu;
    }
}