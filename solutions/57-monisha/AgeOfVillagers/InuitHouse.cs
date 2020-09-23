using System.Drawing;

namespace AgeOfVillagers
{
    public class InuitHouse : CompositeShape
    {
        public InuitHouse(Point MPt)
        {                      
            Point Lpt1 = new Point(MPt.X - 6, MPt.Y + 10);
            Point Lpt2 = new Point(MPt.X + 10, MPt.Y + 10);
            Point Opt1 = new Point(MPt.X -1, MPt.Y + 7 );

            AddComp(new Line(Lpt1, Lpt2));
            AddComp(new ShapeArc(Opt1.X, Opt1.Y, 6, 4, 0, -180.0F));
            AddComp(new ShapeArc(Lpt1.X, Lpt1.Y - 8, 16, 14, 0, -180.0F));
        }
    }
}
