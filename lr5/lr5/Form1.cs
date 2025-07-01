using System;
using System.Windows.Forms;

namespace Lab5Graphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHermite_Click(object sender, EventArgs e)
        {
            HermiteForm hf = new HermiteForm();
            hf.Show();
        }

        private void btnKoch_Click(object sender, EventArgs e)
        {
            KochForm kf = new KochForm();
            kf.Show();
        }
    }
}
