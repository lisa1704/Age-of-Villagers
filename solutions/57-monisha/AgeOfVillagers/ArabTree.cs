using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
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

