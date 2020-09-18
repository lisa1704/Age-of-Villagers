using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_of_Villagers
{
    public class BangladeshiWaterSource : IWaterSource
    {
        public void drawWaterSource(Axes axes, Panel drawingSpace)
        {
            Pen pen = new Pen(Color.Black);
            Graphics elem = drawingSpace.CreateGraphics();

            elem.DrawLine(pen, new PointF(axes.X, axes.Y), new PointF(axes.X - 3, axes.Y - 3));
            elem.DrawLine(pen, new PointF(axes.X - 3, axes.Y - 3), new PointF(axes.X - 6, axes.Y + 5));
            elem.DrawLine(pen, new PointF(axes.X - 6, axes.Y + 5), new PointF(axes.X - 12, axes.Y - 1));
            elem.DrawLine(pen, new PointF(axes.X - 12, axes.Y - 1), new PointF(axes.X - 24, axes.Y + 6));
            elem.DrawLine(pen, new PointF(axes.X - 24, axes.Y + 6), new PointF(axes.X - 13, axes.Y + 24));
            elem.DrawLine(pen, new PointF(axes.X - 13, axes.Y + 24), new PointF(axes.X, axes.Y + 10));
            elem.DrawLine(pen, new PointF(axes.X, axes.Y + 10), new PointF(axes.X, axes.Y));
        }
    }
}
