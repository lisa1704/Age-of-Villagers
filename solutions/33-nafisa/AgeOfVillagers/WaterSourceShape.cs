using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{

    class WaterSourceShape : IShape
    {
        private Panel Drawingpanel;

        public WaterSourceShape(Panel Drawingpanel)
        {
            this.Drawingpanel = Drawingpanel;
        }
        public void Draw(Point point, Panel Drawingpanel)
        {
            Graphics g = Drawingpanel.CreateGraphics();
            Pen p = new Pen(Color.Black);
            g.DrawLine(p, point.X, point.Y, point.X+24, point.Y-30);
            g.DrawLine(p, point.X , point.Y, point.X+26, point.Y+30);
            g.DrawLine(p, point.X+24, point.Y-30, point.X + 46, point.Y - 33);
            g.DrawLine(p, point.X + 46, point.Y - 33, point.X+50, point.Y-20);
            g.DrawLine(p,  point.X+50, point.Y-20, point.X + 70, point.Y-36);
            g.DrawLine(p, point.X + 70, point.Y-36, point.X + 90, point.Y - 10);
            g.DrawLine(p, point.X + 90, point.Y - 10, point.X +65, point.Y + 15);
            g.DrawLine(p, point.X + 65, point.Y + 15, point.X +55, point.Y +5);
            g.DrawLine(p, point.X + 26, point.Y + 30, point.X + 55, point.Y + 5);

        }
    }
}
