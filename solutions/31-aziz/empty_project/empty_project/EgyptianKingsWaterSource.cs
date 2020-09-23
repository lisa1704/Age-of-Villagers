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

            graphics.DrawEllipse(pen, axis.X, axis.Y, 12, 12);
        }
    }
}
