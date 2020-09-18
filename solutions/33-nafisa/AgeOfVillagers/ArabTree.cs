using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class ArabTree : IShape
    {
        private Panel Drawingpanel;

        public ArabTree(Panel Drawingpanel)
        {
            this.Drawingpanel = Drawingpanel;
        }
        public void Draw(Point point, Panel Drawingpanel)
        {
            Graphics g = Drawingpanel.CreateGraphics();
            Pen p = new Pen(Color.Black);
            g.DrawLine(p, point.X, point.Y, point.X + 4, point.Y);
            g.DrawLine(p, point.X, point.Y, point.X , point.Y - 30);
            g.DrawLine(p, point.X , point.Y - 30, point.X + 4, point.Y-30);
            g.DrawLine(p, point.X + 4, point.Y - 30, point.X + 4, point.Y );
            g.DrawLine(p, point.X + 2, point.Y - 30, point.X + 2, point.Y - 60);
            g.DrawLine(p, point.X + 2, point.Y - 30, point.X + 30, point.Y - 55);
            g.DrawLine(p, point.X + 2, point.Y - 30, point.X - 30, point.Y - 55);
            g.DrawLine(p, point.X + 2, point.Y - 30, point.X + 30, point.Y - 40);
            g.DrawLine(p, point.X + 2, point.Y - 30, point.X - 30, point.Y - 40);
            //g.DrawLine(p, point.X, point.Y, point.X + 15, point.Y - 30);
        }
    }
}
