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
        public void drawWaterSource(Axis axes, Panel drawingSpace)
        {
            Pen pen = new Pen(Color.Black);
            Graphics elem = drawingSpace.CreateGraphics();

            elem.DrawLine(pen, new PointF(axes.X , axes.Y - 6), new PointF(axes.X + 6, axes.Y - 12));
            elem.DrawLine(pen, new PointF(axes.X + 6, axes.Y - 12), new PointF(axes.X + 8, axes.Y - 6));
            elem.DrawLine(pen, new PointF(axes.X + 8, axes.Y - 6), new PointF(axes.X + 11, axes.Y - 12));
            elem.DrawLine(pen, new PointF(axes.X + 11, axes.Y - 12), new PointF(axes.X + 14, axes.Y - 12));
            elem.DrawLine(pen, new PointF(axes.X + 14, axes.Y - 12), new PointF(axes.X + 16, axes.Y - 6));
            elem.DrawLine(pen, new PointF(axes.X + 16, axes.Y - 6), new PointF(axes.X + 11, axes.Y));
            elem.DrawLine(pen, new PointF(axes.X + 11, axes.Y), new PointF(axes.X + 7, axes.Y - 2));
            elem.DrawLine(pen, new PointF(axes.X + 7, axes.Y - 2), new PointF(axes.X + 3, axes.Y));
            elem.DrawLine(pen, new PointF(axes.X + 3, axes.Y), new PointF(axes.X, axes.Y - 6));
        }
    }
}
