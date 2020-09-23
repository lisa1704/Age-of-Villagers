using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillager
{
    public class EgyptianKingsWaterSource : IWaterSource
    {
        int x, y, width, height, startAngle, sweepAngle;
        private readonly Graphics g;

        public EgyptianKingsWaterSource(Graphics graphics)
        {
            this.g = graphics;
        }
        Pen myPen = new Pen(Color.Black);

        public void draw(MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            width = 12;
            height = 12;
            startAngle = 0;
            sweepAngle = 360;
            g.DrawArc(myPen, x, y, width, height, startAngle, sweepAngle);
        }
    }
}
