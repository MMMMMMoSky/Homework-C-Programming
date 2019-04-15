using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw7_CayleyTree
{
    public partial class Form1 : Form
    {

        private Graphics graphics;
        private Pen pen = Pens.Blue;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.4;
        double per2 = 0.5;

        public Form1()
        {
            InitializeComponent();
 
        }

        private void draw_Click(object sender, EventArgs e)
        {
            if (graphics == null)
            {
                graphics = this.CreateGraphics();
            }
            graphics.Clear(Color.White);
            drawCayleyTree(10, 200, 310, 100, -Math.PI / 2);
        }

        void drawCayleyTree(int n, double x0, double y0, double len, double th)
        {
            if (n == 0)
            {
                return;
            }

            double x1 = x0 + len * Math.Cos(th);
            double y1 = y0 + len * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, per1 * len, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * len, th - th2);
        }

        void drawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void vScrollBar_per1_Scroll(object sender, ScrollEventArgs e)
        {
            per1 = (double)this.vScrollBar_per1.Value / 100;
        }

        private void vScrollBar_per2_Scroll(object sender, ScrollEventArgs e)
        {
            per2 = (double)this.vScrollBar_per2.Value / 100;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void color_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.color.SelectedIndex)
            {
                case 0:
                    pen = Pens.Red;
                    break;
                case 1:
                    pen = Pens.Yellow;
                    break;
                case 2:
                    pen = Pens.Blue;
                    break;
                case 3:
                    pen = Pens.Black;
                    break;
                case 4:
                    pen = Pens.Pink;
                    break;
                default:
                    pen = Pens.Blue;
                    break;
            }
        }
    }
}
