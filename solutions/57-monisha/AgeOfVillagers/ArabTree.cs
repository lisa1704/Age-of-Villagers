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
                Point bottomRight = new Point(MPt.X + 24, MPt.Y + 65);
                Point topPt = new Point(MPt.X + 40, MPt.Y + 45);
                Point RTopLeft = new Point(MPt.X + 20, MPt.Y+25);

                AddComp(new ShapeRectangle(RTopLeft, bottomRight));
                AddComp(new ShapeEllipse(MPt, topPt));
            }
        }
        public class EgyptianTree : CompositeShape
        {
            public EgyptianTree(Point MPt)
            {               
                Point L1topPt = new Point(MPt.X +25, MPt.Y - 50);
                Point L2topPt = new Point(MPt.X - 25, MPt.Y - 45);
             
                Point RTopLeft = new Point(MPt.X , MPt.Y );
                Point ULpoint3 = new Point(MPt.X + 15, MPt.Y - 30);
                Point ULpoint4 = new Point(MPt.X + 40, MPt.Y - 45);
                Point ULpoint5 = new Point(MPt.X + 10, MPt.Y - 50);
                Point URpoint6 = new Point(MPt.X - 16, MPt.Y - 30);
                Point URpoint7 = new Point(MPt.X - 10, MPt.Y - 50);
                Point URpoint8 = new Point(MPt.X - 35, MPt.Y - 40);

                AddComp(new Line(RTopLeft, L1topPt));
                AddComp(new Line(RTopLeft, L2topPt));
                AddComp(new Line(ULpoint3, ULpoint4));
                AddComp(new Line(ULpoint3, ULpoint5));
                AddComp(new Line(URpoint6, URpoint7));
                AddComp(new Line(URpoint6, URpoint8));

            }
        }
        public class ArabTree : CompositeShape
        {
            public ArabTree(Point MPt)
            {
                Point topRight = new Point(MPt.X + 22, MPt.Y+20);
                Point bottomRight = new Point(MPt.X + 25, MPt.Y + 65);
                Point L1topPt = new Point(MPt.X-12 , MPt.Y -25);
                Point L2topPt = new Point(MPt.X +57, MPt.Y - 25);
                Point L3topPt = new Point(topRight.X, MPt.Y - 35);
                Point L4topPt = new Point(MPt.X + 78, MPt.Y - 10);
                Point L5topPt = new Point(MPt.X - 35, MPt.Y - 8);
                Point RTopLeft = new Point(MPt.X + 20, MPt.Y + 20);
               // Point RTopLeft = new Point(MPt.X , MPt.Y );

                AddComp(new ShapeRectangle(RTopLeft, bottomRight));
                AddComp(new Line(RTopLeft, L1topPt));
                AddComp(new Line(topRight, L2topPt));
                AddComp(new Line(topRight, L3topPt));
                AddComp(new Line(topRight, L4topPt));
                AddComp(new Line(topRight, L5topPt));
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
            }
        }
    }
}

