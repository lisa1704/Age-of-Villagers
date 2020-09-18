using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class ArabHouse : IShape
    {
        private Panel Drawingpanel;

        public ArabHouse(Panel Drawingpanel)
        {
            this.Drawingpanel = Drawingpanel;
        }
        public void Draw(Point point, Panel Drawingpanel)
        {
            Graphics g = Drawingpanel.CreateGraphics();
            Pen p = new Pen(Color.Black);
            g.DrawLine(p, point.X, point.Y, point.X + 30, point.Y);
            g.DrawLine(p, point.X + 30, point.Y, point.X + 15, point.Y -30 );
            g.DrawLine(p, point.X + 15, point.Y - 30, point.X + 30, point.Y);
            g.DrawLine(p, point.X + 30, point.Y, point.X+45, point.Y -10);
            g.DrawLine(p, point.X + 45, point.Y - 10, point.X + 15, point.Y - 30);
            g.DrawLine(p, point.X, point.Y, point.X + 15, point.Y - 30);

        }
    }
}
