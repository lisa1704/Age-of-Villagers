using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class InuitHunters : INation
    {

        private readonly Graphics g;
        Pen mypen = new Pen(Color.Black, 1);

        public InuitHunters(Graphics g)
        {
            this.g = g;
        }

        public void DrawHouse(MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;

            /*Point linePoint1 = new Point(e.X, e.Y);
            Point linePoint2 = new Point(e.X + 16, e.Y);
            Point arcPoint1 = new Point(e.X, e.Y - 16);
            int height1 = 32;
            int width1 = 16;

            Point linePoint3 = new Point(e.X + 5, e.Y);
            Point linePoint4 = new Point(e.X + 12, e.Y);
            Point arcPoint2 = new Point(e.X + 5, e.Y - 6);
            int height2 = 12;
            int width2 = 6;


            g.DrawLine(mypen, x, y, x + 24, y - 28);
            g.DrawLine(mypen, x + 24, y - 28, x - 12, y - 64);
            g.DrawLine(mypen, x - 12, y - 64, x - 40, y - 16);
            g.DrawLine(mypen, x - 40, y - 16, x, y);
            g.DrawLine(mypen, x - 12, y - 64, x, y);*/
        }

        public void DrawTree(MouseEventArgs e)
        {
            
        }

        public void DrawWaterSource(MouseEventArgs e)
        {
            
        }
    }
}
