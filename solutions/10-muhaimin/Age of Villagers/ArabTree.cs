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
        public void drawTree(Axis axes, Panel drawingSpace)
        {
            Pen pen = new Pen(Color.Black);
            Graphics elem = drawingSpace.CreateGraphics();

            //drawing the rectangle
            elem.DrawRectangle(pen, axes.X, axes.Y, 2, 12);

            //drawng the branches
            elem.DrawLine(pen, new PointF(axes.X + 1, axes.Y), new PointF(axes.X + 1, axes.Y - 26));
            elem.DrawLine(pen, new PointF(axes.X + 1, axes.Y), new PointF(axes.X + 5, axes.Y - 21));
            elem.DrawLine(pen, new PointF(axes.X + 1, axes.Y), new PointF(axes.X + 9, axes.Y - 16));
            elem.DrawLine(pen, new PointF(axes.X + 1, axes.Y), new PointF(axes.X + 13, axes.Y - 11));
            elem.DrawLine(pen, new PointF(axes.X + 1, axes.Y), new PointF(axes.X + 17, axes.Y - 5));
            elem.DrawLine(pen, new PointF(axes.X + 1, axes.Y), new PointF(axes.X + 21, axes.Y - 1));
            elem.DrawLine(pen, new PointF(axes.X + 1, axes.Y), new PointF(axes.X - 1, axes.Y - 26));
            elem.DrawLine(pen, new PointF(axes.X + 1, axes.Y), new PointF(axes.X - 5, axes.Y - 21));
            elem.DrawLine(pen, new PointF(axes.X + 1, axes.Y), new PointF(axes.X - 9, axes.Y - 16));
            elem.DrawLine(pen, new PointF(axes.X + 1, axes.Y), new PointF(axes.X - 13, axes.Y - 11));
            elem.DrawLine(pen, new PointF(axes.X + 1, axes.Y), new PointF(axes.X - 17, axes.Y - 6));
            elem.DrawLine(pen, new PointF(axes.X + 1, axes.Y), new PointF(axes.X - 21, axes.Y - 1));
        }
    }
}
