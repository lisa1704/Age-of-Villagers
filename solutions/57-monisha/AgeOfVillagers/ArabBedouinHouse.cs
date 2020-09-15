using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    public class BDHouse : CompositeShape
    {
        public BDHouse(Point top, Point topLeft, Point bottomRight)
        {
            AddComp(new ShapeRectangle(topLeft, bottomRight));
            AddComp(new Triangle(top, topLeft, new Point(bottomRight.X, topLeft.Y)));
        }

    }
    class ArabBedouinHouse : CompositeShape
    {
        public ArabBedouinHouse(Point MPt)
        {
            Point tpt1 = new Point(MPt.X - 24, MPt.Y + 50);
            Point tpt2 = new Point(MPt.X + 24, MPt.Y + 50);
            Point rpt1 = new Point(tpt2.X+25, tpt2.Y -15);
            Point rpt2 = new Point(MPt.X + 25, MPt.Y - 15);
            


            AddComp(new Triangle(tpt2, tpt1, MPt));
            AddComp(new Line(MPt, rpt2));
            AddComp(new Line(tpt2, rpt1));
            AddComp(new Line(rpt2, rpt1));

        }
    }
}
