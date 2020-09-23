using System.Drawing;

namespace AgeOfVillagers
{
    public class EgyptianHouse : CompositeShape
    {
        public EgyptianHouse(Point MPt)
        {
            Point tpt1 = new Point(MPt.X - 10, MPt.Y + 14);
            Point tpt2 = new Point(MPt.X + 6, MPt.Y + 16);
            Point tpt3 = new Point(tpt2.X + 6, tpt2.Y - 10);            

            AddComp(new Triangle(tpt2, tpt1, MPt));
            AddComp(new Triangle(tpt3, tpt2, MPt));    

        }
    }
}
