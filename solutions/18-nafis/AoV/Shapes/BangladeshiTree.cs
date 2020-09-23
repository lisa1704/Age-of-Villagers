using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AoV.Shapes
{
    class BangladeshiTree : ComposeShape
    {

        private Point p1, p2;
        private float ellHeight, height, width;

        public BangladeshiTree(Point clickPoint)
        {
            Point rightPoint = new Point(clickPoint.X + 100, clickPoint.Y);
            Point topLeftPoint = new Point(clickPoint.X + 40, clickPoint.Y + 60);
            Point bottomRightPoint = new Point(clickPoint.X + 50, clickPoint.Y + 180);
            Point topPoint = new Point(clickPoint.X + 100, clickPoint.Y + 90);


            AddShape(new Rectangle(topLeftPoint, bottomRightPoint));
            AddShape(new Ellipse(clickPoint, topPoint));
        }

    }
}
