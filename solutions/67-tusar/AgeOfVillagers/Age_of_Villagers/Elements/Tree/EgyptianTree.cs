using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_of_Villagers
{
    public class EgyptianTree : ITree
    {
        public void drawTree(Axes axes, Panel drawingSpace)
        {
            Pen pen = new Pen(Color.Black);
            Graphics elem = drawingSpace.CreateGraphics();

            elem.DrawLine(pen, new PointF(axes.X, axes.Y), new PointF(axes.X + 4, axes.Y - 20));
            elem.DrawLine(pen, new PointF(axes.X, axes.Y), new PointF(axes.X - 4, axes.Y - 20));

            elem.DrawLine(pen, new PointF(axes.X + 4, axes.Y - 20), new PointF(axes.X + 4, axes.Y - 24));
            elem.DrawLine(pen, new PointF(axes.X + 4, axes.Y - 20), new PointF(axes.X + 8, axes.Y - 20));
            elem.DrawLine(pen, new PointF(axes.X + 4, axes.Y - 20), new PointF(axes.X + 8, axes.Y - 24));

            elem.DrawLine(pen, new PointF(axes.X - 4, axes.Y - 20), new PointF(axes.X - 4, axes.Y - 24));
            elem.DrawLine(pen, new PointF(axes.X - 4, axes.Y - 20), new PointF(axes.X - 8, axes.Y - 20));
            elem.DrawLine(pen, new PointF(axes.X - 4, axes.Y - 20), new PointF(axes.X - 8, axes.Y - 24));
        }
    }
}
