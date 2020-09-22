using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace empty_project
{
    public class ArabBedouinHouse : IHouse
    {
        public void drawHouse(Axis axis, Panel panel)
        {
            Pen pen = new Pen(Color.Black);
            Graphics graphics = panel.CreateGraphics();

            graphics.DrawLine(pen, new PointF(axis.X, axis.Y), new PointF(axis.X - 24, axis.Y + 50));
            graphics.DrawLine(pen, new PointF(axis.X - 24, axis.Y + 50), new PointF(axis.X + 16, axis.Y + 50));
            graphics.DrawLine(pen, new PointF(axis.X + 16, axis.Y + 50), new PointF(axis.X, axis.Y));

            graphics.DrawLine(pen, new PointF(axis.X, axis.Y), new PointF(axis.X + 25,axis.Y - 30));
            graphics.DrawLine(pen, new PointF(axis.X + 25, axis.Y - 30), new PointF(axis.X + 41, axis.Y + 20));
            graphics.DrawLine(pen, new PointF(axis.X + 41, axis.Y + 20), new PointF(axis.X + 16, axis.Y + 50));
        }
    }
}
