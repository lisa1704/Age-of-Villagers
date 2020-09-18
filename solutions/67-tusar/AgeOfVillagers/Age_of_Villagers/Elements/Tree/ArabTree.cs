using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_of_Villagers
{
    public class ArabTree : ITree
    {
        public void drawTree(Axes axes, Panel drawingSpace)
        {
            Pen pen = new Pen(Color.Black);
            Graphics elem = drawingSpace.CreateGraphics();

            //drawing the rectangle
            elem.DrawRectangle(pen, axes.X, axes.Y, 2, 12);

            //drawng the branches
            elem.DrawLine(pen, new PointF(axes.X + 1, axes.Y), new PointF(axes.X + 1, axes.Y - 12));
            elem.DrawLine(pen, new PointF(axes.X + 1, axes.Y), new PointF(axes.X + 4, axes.Y - 12));
            elem.DrawLine(pen, new PointF(axes.X + 1, axes.Y), new PointF(axes.X + 6, axes.Y - 12));
            elem.DrawLine(pen, new PointF(axes.X + 1, axes.Y), new PointF(axes.X + 8, axes.Y - 12));
            elem.DrawLine(pen, new PointF(axes.X + 1, axes.Y), new PointF(axes.X - 3, axes.Y - 12));
            elem.DrawLine(pen, new PointF(axes.X + 1, axes.Y), new PointF(axes.X - 5, axes.Y - 12));
            elem.DrawLine(pen, new PointF(axes.X + 1, axes.Y), new PointF(axes.X - 7, axes.Y - 12));
        }
    }
}
