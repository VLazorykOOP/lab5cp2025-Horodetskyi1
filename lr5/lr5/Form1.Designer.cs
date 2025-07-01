using System;
using System.Windows.Forms;

namespace Lab5Graphics
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnHermite;
        private Button btnKoch;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnHermite = new System.Windows.Forms.Button();
            this.btnKoch = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // btnHermite
            // 
            this.btnHermite.Location = new System.Drawing.Point(40, 30);
            this.btnHermite.Name = "btnHermite";
            this.btnHermite.Size = new System.Drawing.Size(200, 40);
            this.btnHermite.Text = "Крива Ерміта";
            this.btnHermite.Click += new System.EventHandler(this.btnHermite_Click);

            // 
            // btnKoch
            // 
            this.btnKoch.Location = new System.Drawing.Point(40, 90);
            this.btnKoch.Name = "btnKoch";
            this.btnKoch.Size = new System.Drawing.Size(200, 40);
            this.btnKoch.Text = "Фрактал Коха";
            this.btnKoch.Click += new System.EventHandler(this.btnKoch_Click);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.btnHermite);
            this.Controls.Add(this.btnKoch);
            this.Name = "Form1";
            this.Text = "Меню ЛР5";
            this.ResumeLayout(false);
        }
    }
}
