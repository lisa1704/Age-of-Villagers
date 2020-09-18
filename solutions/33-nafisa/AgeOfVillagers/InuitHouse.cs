using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class InuitHouse : IShape
    {
        private Panel Drawingpanel;

        public InuitHouse(Panel Drawingpanel)
        {
            this.Drawingpanel = Drawingpanel;
        }
        public void Draw(Point point, Panel Drawingpanel)
        {
            Graphics g = Drawingpanel.CreateGraphics();
            Pen p = new Pen(Color.Black);
           
            g.DrawArc(p, point.X, point.Y, 16, 16, 0, -180);
            g.DrawArc(p, point.X + 4, point.Y + 4, 8, 8, 0, -180);
            g.DrawLine(p, point.X, point.Y + 8, point.X + 16, point.Y+8);
            
        }
    }
}
