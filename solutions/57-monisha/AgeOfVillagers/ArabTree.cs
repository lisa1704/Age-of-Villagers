using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public class EgyptianTree : CompositeShape
        {
            public EgyptianTree(Point MPt)
            {               
                Point L1topPt = new Point(MPt.X +6, MPt.Y - 22);
                Point L2topPt = new Point(MPt.X - 7, MPt.Y - 23);
             
                Point RTopLeft = new Point(MPt.X , MPt.Y );
                Point ULpoint3 = new Point(MPt.X + 4, MPt.Y - 15);
                Point ULpoint4 = new Point(MPt.X + 8, MPt.Y - 20);
                Point ULpoint5 = new Point(MPt.X + 2, MPt.Y - 20);
                Point URpoint6 = new Point(MPt.X - 4, MPt.Y - 15);
                Point URpoint7 = new Point(MPt.X - 2, MPt.Y - 22);
                Point URpoint8 = new Point(MPt.X - 8, MPt.Y - 20);

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
                //int length = (MPt.Y+12)-MPt.Y;
                /*//Point bottomRight = new Point(MPt.X +22, MPt.Y + 40);
                Point L1topPt = new Point(MPt.X - 12, MPt.Y - 25);
                Point L2topPt = new Point(MPt.X + 57, MPt.Y - 25);
                Point L3topPt = new Point(topRight.X, MPt.Y - 35);
                Point L4topPt = new Point(MPt.X + 78, MPt.Y - 10);
                Point L5topPt = new Point(MPt.X - 35, MPt.Y - 8);
                Point RTopLeft = new Point(MPt.X + 20, MPt.Y + 20);*/
                Point RTopLeft = new Point(MPt.X , MPt.Y );
                Point bottomRight = new Point(MPt.X + 2, MPt.Y + 12);
                Point RecMid = new Point(MPt.X + 1, MPt.Y );
                Point L1topPt = new Point(RecMid.X - 5, MPt.Y - 9);
                Point L2topPt = new Point(RecMid.X + 5, MPt.Y - 9);
                Point L3topPt = new Point(RecMid.X , MPt.Y - 12);
                Point L4topPt = new Point(RecMid.X + 8, MPt.Y - 6);
                Point L5topPt = new Point(RecMid.X - 8, MPt.Y - 5);
             
                AddComp(new ShapeRectangle(RTopLeft, bottomRight));
                AddComp(new Line(RecMid, L3topPt));
                AddComp(new Line(RecMid, L1topPt));
                AddComp(new Line(RecMid, L2topPt));
                AddComp(new Line(RecMid, L3topPt));
                AddComp(new Line(RecMid, L4topPt));
                AddComp(new Line(RecMid, L5topPt));
            }
            public int GetBBox()
            {
                int length = 12 , weight=16;
                return (length * weight);
            }
        }
}

