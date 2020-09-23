using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AgeOfVillagers.ShapeArc;

namespace AgeOfVillagers
{
    public class ArabBedouinHouse : CompositeShape
    {
        public ArabBedouinHouse(Point MPt)
        {
            Point tpt1 = new Point(MPt.X - 6, MPt.Y + 10);
            Point tpt2 = new Point(MPt.X + 6, MPt.Y + 10);
            Point rpt1 = new Point(tpt2.X + 10, tpt2.Y - 4);
            Point rpt2 = new Point(MPt.X + 8, MPt.Y - 6);          

            AddComp(new Triangle(tpt2, tpt1, MPt));
            AddComp(new ShapeRectangle(MPt, rpt1, tpt2, rpt2));        

        }
    }
}
