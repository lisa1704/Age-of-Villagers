using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class InuitIgloo : AdvancedShape
    {
        public InuitIgloo(Point clickPoint)
        {
            Point p1 = new Point(clickPoint.X - 50, clickPoint.Y+40);
            Point p2 = new Point(clickPoint.X + 50, clickPoint.Y+40);
            Point arcP1 = new Point(clickPoint.X - 50, clickPoint.Y);
            Point arcP2 = new Point(clickPoint.X + 50, clickPoint.Y);

            addShape(new LineShape(p1, p2));
            addShape(new ArcShape(arcP1.X,arcP2.Y,80,100,0,-180));
            addShape(new ArcShape(arcP1.X+25, arcP2.Y+25, 30, 50, 0, -180));
        } 
    }
}
