using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillager
{
    class EgyptianKingsWaterSource : IWaterSource
    {
        private readonly Graphics g;

        public EgyptianKingsWaterSource(Graphics graphics)
        {
            this.g = graphics;
        }
        int x, y, radius;
        Pen myPen = new Pen(Color.Black);

        public void draw(MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            radius = 12;
            g.DrawEllipse(myPen, x - radius, y - radius,
                      radius + radius, radius + radius);
        }
    }
}
