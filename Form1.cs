using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhysicsProject
{
    public partial class Form1 : Form
    {
        Point p1 = new Point(400, 400);
        Point p2 = new Point(0, 0);
        Random rand = new Random();
        System.Drawing.Graphics graphics;
        Form2 f = new Form2();
        int k = 0;
        public Form1()
        {
            InitializeComponent();
            this.ClientSize = new Size(800, 800);
            this.BackColor = Color.Black;
            f.Show();
            graphics = this.CreateGraphics();
        }

        public void clear()
        {
            graphics.Clear(Color.Black);
            k = 0;
            f.clear();
        }

        private void PaintLine(Point p1, Point p2, Color col)
        {
            Pen pen = new Pen(col);
            graphics.DrawLine(pen, p1, p2);
            pen.Dispose();
        }

        public void addLine(int steps)
        {
            k++;
            int i = 0;
            Color col = Color.FromArgb(rand.Next(0,256), rand.Next(0, 256), rand.Next(0, 256));
            p1.X = 400;
            p1.Y = 400;
            f.AddColumn();
            while (i <= steps)
            {
                i++;
                double alpha = rand.NextDouble() + rand.Next(0, 360);
                double x = p1.X + 46 * Math.Cos(alpha);
                double y = p1.Y + 46 * Math.Sin(alpha);
                p2.X = (int)x;
                p2.Y = (int)y;
                PaintLine(p1, p2, col);
                if (Math.Floor(Math.Sqrt(i)) == Math.Sqrt(i))
                {
                    f.AddData(k - 1,Math.Sqrt((p2.X - 400) * (p2.X - 400) + (p2.Y - 400) * (p2.Y - 400)));
                }
                p1 = p2;
            }
        }
    }
}



// 46 пикселей - 1 сантиметр!!!!!!!!!!!!