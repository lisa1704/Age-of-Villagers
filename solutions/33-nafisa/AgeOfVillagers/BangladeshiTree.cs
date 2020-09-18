using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class BangladeshiTree : IShape
    {
        private Panel Drawingpanel;
        public BangladeshiTree(Panel Drawingpanel)
        {
            this.Drawingpanel = Drawingpanel;
        }
        public void Draw(Point point, Panel Drawingpanel)
        {
            Graphics g = Drawingpanel.CreateGraphics();
            Pen p = new Pen(Color.Black);
            g.DrawArc(p, point.X, point.Y, 16, 24, 45, 360);
            g.DrawLine(p, point.X+8, point.Y+16, point.X+8, point.Y+48);
        }
    }
}
