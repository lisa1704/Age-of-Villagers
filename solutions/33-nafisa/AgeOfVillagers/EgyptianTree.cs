using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class EgyptianTree : IShape
    {
        private Panel Drawingpanel;

        public EgyptianTree(Panel Drawingpanel)
        {
            this.Drawingpanel = Drawingpanel;
        }
        public void Draw(Point point, Panel Drawingpanel)
        {
            Graphics g = Drawingpanel.CreateGraphics();
            Pen p = new Pen(Color.Black);
            g.DrawLine(p, point.X, point.Y, point.X + 25, point.Y - 40);
            g.DrawLine(p, point.X, point.Y, point.X - 25, point.Y - 40);
            g.DrawLine(p, point.X + 19, point.Y - 28, point.X + 15, point.Y - 40);
            g.DrawLine(p, point.X + 19, point.Y - 28, point.X + 30 , point.Y - 38);
            g.DrawLine(p, point.X - 19, point.Y - 30, point.X - 15, point.Y - 40);
            g.DrawLine(p, point.X - 19, point.Y - 30, point.X - 30, point.Y - 38);
            
        }
    }
}
