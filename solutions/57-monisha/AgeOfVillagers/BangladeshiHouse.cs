using System.Drawing;

namespace AgeOfVillagers
{
    public class BangladeshiHouse : CompositeShape
    {
        public string testBdHouse;
        public BangladeshiHouse(Point MPt)
        {            
            Point tpt1 = new Point(MPt.X + 16, MPt.Y );
            Point tpt2 = new Point(MPt.X + 8, MPt.Y -8);
            Point rpt1 = new Point(tpt1.X , tpt1.Y);
            Point rpt2 = new Point(MPt.X , MPt.Y + 8);

            AddComp(new Triangle(tpt1, tpt2, MPt));
            AddComp(new ShapeRectangle(rpt1, rpt2));
            testBdHouse = "BDHouse Constructed";
        }
     
    }
}
