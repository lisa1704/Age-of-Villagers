using System;
using System.Drawing;
using static AgeOfVillagers.ShapeArc;

namespace AgeOfVillagers
{
    partial class DrawArc
    {
        public class BDTree : CompositeShape
        {
            public BDTree(Point MPt)
            {
                Point topRight = new Point(MPt.X + 20, MPt.Y);
                Point bottomRight = new Point(MPt.X + 25, MPt.Y + 50);
                Point topPt = new Point(MPt.X + 40, MPt.Y + 40);
                Point RTopLeft = new Point(MPt.X + 20, MPt.Y + 20);

                AddComp(new ShapeRectangle(RTopLeft, bottomRight));
                AddComp(new ShapeEllipse(MPt, topPt));
            }

        }
        public class EgyptianTree : CompositeShape
        {
            public EgyptianTree(Point MPt)
            {
                Point topRight = new Point(MPt.X + 22, MPt.Y + 20);
                Point bottomRight = new Point(MPt.X + 25, MPt.Y + 50);
                Point L1topPt = new Point(MPt.X - 5, MPt.Y - 35);
                Point L2topPt = new Point(MPt.X + 50, MPt.Y - 35);
                Point L3topPt = new Point(MPt.X + 20, MPt.Y - 35);
                Point RTopLeft = new Point(MPt.X + 20, MPt.Y + 20);
                Point point3 = new Point(MPt.X + 15, MPt.Y - 30);
               /* Point point4 = new Point(mainPoint.X + 40, mainPoint.Y - 45);
                Point point5 = new Point(mainPoint.X + 10, mainPoint.Y - 50);
                Point point6 = new Point(mainPoint.X - 16, mainPoint.Y - 30);
                Point point7 = new Point(mainPoint.X - 10, mainPoint.Y - 50);
                Point point8 = new Point(mainPoint.X - 35, mainPoint.Y - 50);
*/
                AddComp(new Line(RTopLeft, L1topPt));
                AddComp(new Line(RTopLeft, L2topPt));
                /* AddComp(new Line(topRight, L2topPt));
                 AddComp(new Line(topRight, L3topPt));*/
            }
        }
        public class ArabTree : CompositeShape
        {
            public ArabTree(Point MPt)
            {
                Point topRight = new Point(MPt.X + 22, MPt.Y+20);
                Point bottomRight = new Point(MPt.X + 25, MPt.Y + 50);
                Point L1topPt = new Point(MPt.X-5 , MPt.Y -35);
                Point L2topPt = new Point(MPt.X +50, MPt.Y - 35);
                Point L3topPt = new Point(MPt.X + 20, MPt.Y - 35);
                Point RTopLeft = new Point(MPt.X + 20, MPt.Y + 20);

                AddComp(new ShapeRectangle(RTopLeft, bottomRight));
                AddComp(new Line(RTopLeft, L1topPt));
                AddComp(new Line(topRight, L2topPt));
                AddComp(new Line(topRight, L3topPt));
            }
        }

        public class NullTree : CompositeShape
        {
            public NullTree( )
            {
                //No Tree
            }

            internal void Paint(Graphics g, Pen p)
            {
                //No Tree
                throw new NotImplementedException();
            }
        }
    }
}

