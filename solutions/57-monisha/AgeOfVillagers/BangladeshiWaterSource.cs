using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static AgeOfVillagers.DrawArc;
using static AgeOfVillagers.ShapeArc;

namespace AgeOfVillagers
{
   public class BangladeshiWaterSource : CompositeShape
    {
        public BangladeshiWaterSource(Point MPt)
        {
            Point pt1 = new Point(MPt.X - 4, MPt.Y + 2);
            Point pt2 = new Point(MPt.X - 8, MPt.Y + 10);
            Point pt3 = new Point(MPt.X - 2, MPt.Y + 16);
            Point pt4 = new Point(MPt.X + 2, MPt.Y + 12);
            Point pt5 = new Point(MPt.X + 10, MPt.Y + 16);
            Point pt6 = new Point(MPt.X + 16, MPt.Y + 7);
            Point pt7 = new Point(MPt.X + 8, MPt.Y);
            Point pt8 = new Point(MPt.X + 2, MPt.Y + 4);

            AddComp(new Line(MPt, pt1));
            AddComp(new Line(pt1, pt2));
            AddComp(new Line(pt2, pt3));
            AddComp(new Line(pt3, pt4));
            AddComp(new Line(pt4, pt5));
            AddComp(new Line(pt5, pt6));
            AddComp(new Line(pt6, pt7));
            AddComp(new Line(pt7, pt8));
            AddComp(new Line(MPt, pt8));
        }
    }

   public class EgyptianWaterSource : CompositeShape
    {
        public EgyptianWaterSource(Point MPt)
        {
            Point topPt = new Point(MPt.X + 12, MPt.Y + 12);

            AddComp(new ShapeEllipse(MPt, topPt));

        }
    }
    public class NullVillageItem : CompositeShape
    {
        public NullVillageItem(Point MPt)
        {
            //No Paint
        }

        public void Paint(Graphics g, Pen p)
        {
            //No Paint
        }
    }
}
