using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace empty_project
{
    public class InuitHuntersHouse : IHouse
    {
        public void drawHouse(Axis axis, Panel panel)
        {
            Pen pen = new Pen(Color.Black);
            Graphics graphics = panel.CreateGraphics();

            float startAngle = 0.0F;
            float sweepAngle = -180.0F;

            graphics.DrawArc(pen, axis.X, axis.Y, 40, 40, startAngle, sweepAngle);
            graphics.DrawArc(pen, axis.X + 10, axis.Y + 10, 20, 20, startAngle, sweepAngle);
            graphics.DrawLine(pen, new PointF(axis.X, axis.Y + 20), new PointF(axis.X + 40, axis.Y + 20));
        }
    }
}
