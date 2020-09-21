using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_of_Villagers
{
    public class InuitHouse : IHouse
    {
        public void drawHouse(Axis axes, Panel drawingSpace)
        {
            Pen pen = new Pen(Color.Black);
            Graphics elem = drawingSpace.CreateGraphics();

            // Create start and sweep angles on ellipse. 
            float startAngle = 0.0F;
            float sweepAngle = -180.0F;

            // Draw to screen. 
            elem.DrawArc(pen, axes.X, axes.Y, 16, 16, startAngle, sweepAngle);
            elem.DrawArc(pen, axes.X+4, axes.Y+4, 8, 8, startAngle, sweepAngle);
            elem.DrawLine(pen, new PointF(axes.X, axes.Y + 8), new PointF(axes.X + 16, axes.Y + 8));

        }
    }
}
