using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class BangladeshiHouse : IShape
    {
        private Panel Drawingpanel;

        public BangladeshiHouse(Panel Drawingpanel)
        {
            this.Drawingpanel = Drawingpanel;
        }

        public void Draw(Point point, Panel Drawingpanel)
        {
            
            Graphics g = Drawingpanel.CreateGraphics();
            Pen p = new Pen(Color.Black);
            g.DrawLine(p, point.X, point.Y, point.X + 24, point.Y);
            g.DrawLine(p, point.X + 24, point.Y, point.X + 24, point.Y + 16);
            g.DrawLine(p, point.X, point.Y + 16, point.X + 24, point.Y + 16);
            g.DrawLine(p, point.X, point.Y, point.X, point.Y + 16);
            g.DrawLine(p, point.X, point.Y, point.X + 12, point.Y-8);
            g.DrawLine(p, point.X + 24, point.Y, point.X + 12, point.Y - 8);
        }
    }
}
