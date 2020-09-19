using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class BangladeshiTree : AdvancedShape
    {
        public BangladeshiTree(Point clickPoint)
        {
            Point rightPoint = new Point(clickPoint.X + 100, clickPoint.Y);
            Point topLeftPoint = new Point(clickPoint.X + 40, clickPoint.Y + 60);
            Point bottomRightPoint = new Point(clickPoint.X + 50, clickPoint.Y + 180);
            Point topPoint = new Point(clickPoint.X+100, clickPoint.Y+90);
            

            addShape(new RectangleShape(topLeftPoint, bottomRightPoint));
            addShape(new EllipseShape(clickPoint, topPoint));
        }
    }
}
