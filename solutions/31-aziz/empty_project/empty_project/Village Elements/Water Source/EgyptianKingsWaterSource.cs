using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace empty_project
{
    public class EgyptianKingsWaterSource : IWaterSource
    {
        public void drawWaterSource(Axis axis, Panel panel)
        {
            Pen pen = new Pen(Color.Black);
            Graphics graphics = panel.CreateGraphics();

            float startAngle = 0.0F;
            float sweepAngle = 360.0F;

            graphics.DrawArc(pen, axis.X, axis.Y, 12, 12, startAngle, sweepAngle);
        }
    }
}
