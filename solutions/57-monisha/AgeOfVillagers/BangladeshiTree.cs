using System.Drawing;
using static AgeOfVillagers.ShapeArc;

namespace AgeOfVillagers
{
    public class BangladeshiTree : CompositeShape
        {
            public BangladeshiTree(Point MPt)
            {               
                Point bottomRight = new Point(MPt.X + 8, MPt.Y + 24);
                Point topPt = new Point(MPt.X + 16, MPt.Y + 18);
                Point RTopLeft = new Point(MPt.X + 6, MPt.Y+8);

                AddComp(new ShapeRectangle(RTopLeft, bottomRight));
                AddComp(new ShapeEllipse(MPt, topPt));
            }
        }
}

