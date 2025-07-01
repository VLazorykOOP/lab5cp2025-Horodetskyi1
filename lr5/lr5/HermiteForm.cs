using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab5Graphics
{
    public class HermiteForm : Form
    {
        public HermiteForm()
        {
            this.Text = "Крива Ерміта";
            this.ClientSize = new Size(600, 500);
            this.Paint += HermiteForm_Paint;
        }

        private void HermiteForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            PointF P1 = new PointF(150, 350);
            PointF P2 = new PointF(450, 150);
            PointF V1 = new PointF(100, -100);
            PointF V2 = new PointF(-100, 150);

            Pen pen = new Pen(Color.Red, 2);
            Pen vec = new Pen(Color.Gray, 1) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash };
            PointF prev = P1;

            for (float t = 0; t <= 1.0f; t += 0.01f)
            {
                float h1 = 2 * t * t * t - 3 * t * t + 1;
                float h2 = -2 * t * t * t + 3 * t * t;
                float h3 = t * t * t - 2 * t * t + t;
                float h4 = t * t * t - t * t;

                float x = h1 * P1.X + h2 * P2.X + h3 * V1.X + h4 * V2.X;
                float y = h1 * P1.Y + h2 * P2.Y + h3 * V1.Y + h4 * V2.Y;

                PointF curr = new PointF(x, y);
                g.DrawLine(pen, prev, curr);
                prev = curr;
            }

            g.FillEllipse(Brushes.Green, P1.X - 4, P1.Y - 4, 8, 8);
            g.FillEllipse(Brushes.Blue, P2.X - 4, P2.Y - 4, 8, 8);
            g.DrawLine(vec, P1, new PointF(P1.X + V1.X / 2, P1.Y + V1.Y / 2));
            g.DrawLine(vec, P2, new PointF(P2.X + V2.X / 2, P2.Y + V2.Y / 2));
        }
    }
}
