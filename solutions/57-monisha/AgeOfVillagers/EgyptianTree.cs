using System.Drawing;

namespace AgeOfVillagers
{
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
}

