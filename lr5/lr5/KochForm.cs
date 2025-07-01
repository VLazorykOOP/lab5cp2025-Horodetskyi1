using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab5Graphics
{
    public class KochForm : Form
    {
        public KochForm()
        {
            this.Text = "Фрактал Коха";
            this.ClientSize = new Size(600, 600);
            this.Paint += KochForm_Paint;
        }

        private void KochForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            PointF origin = new PointF(200, 300);
            float size = 200;
            int order = 3;
            DrawKochSquare(g, origin, size, order);
        }

        private void DrawKoch(Graphics g, PointF a, PointF b, int depth)
        {
            if (depth == 0)
            {
                g.DrawLine(Pens.Blue, a, b);
                return;
            }

            PointF oneThird = new PointF(a.X + (b.X - a.X) / 3, a.Y + (b.Y - a.Y) / 3);
            PointF twoThird = new PointF(a.X + 2 * (b.X - a.X) / 3, a.Y + 2 * (b.Y - a.Y) / 3);

            float angle = (float)Math.Atan2(b.Y - a.Y, b.X - a.X) - (float)Math.PI / 3;
            float length = (float)Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2)) / 3;
            PointF peak = new PointF(
                oneThird.X + length * (float)Math.Cos(angle),
                oneThird.Y + length * (float)Math.Sin(angle));

            DrawKoch(g, a, oneThird, depth - 1);
            DrawKoch(g, oneThird, peak, depth - 1);
            DrawKoch(g, peak, twoThird, depth - 1);
            DrawKoch(g, twoThird, b, depth - 1);
        }

        private void DrawKochSquare(Graphics g, PointF origin, float size, int depth)
        {
            PointF a = origin;
            PointF b = new PointF(origin.X + size, origin.Y);
            PointF c = new PointF(origin.X + size, origin.Y + size);
            PointF d = new PointF(origin.X, origin.Y + size);

            DrawKoch(g, a, b, depth);
            DrawKoch(g, b, c, depth);
            DrawKoch(g, c, d, depth);
            DrawKoch(g, d, a, depth);
        }
    }
}
