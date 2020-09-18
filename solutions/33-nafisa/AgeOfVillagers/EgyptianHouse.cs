using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class EgyptianHouse : IShape
    {
        private Panel Drawingpanel;

        public EgyptianHouse(Panel Drawingpanel)
        {
            this.Drawingpanel = Drawingpanel;
        }

        public void Draw(Point point, Panel Drawingpanel)
        {
            Graphics g = Drawingpanel.CreateGraphics();
            Pen p = new Pen(Color.Black);
            g.DrawLine(p, point.X, point.Y, point.X + 25, point.Y-15);
            g.DrawLine(p, point.X, point.Y, point.X -30, point.Y - 10);
            g.DrawLine(p, point.X, point.Y, point.X -10, point.Y - 30);
            g.DrawLine(p, point.X - 30, point.Y - 10, point.X - 10, point.Y - 30);
            g.DrawLine(p, point.X + 25, point.Y - 15, point.X - 10, point.Y - 30);
            
            
        }
    }
}
