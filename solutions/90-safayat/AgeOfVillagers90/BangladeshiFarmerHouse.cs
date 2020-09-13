using System.Drawing;

namespace AgeOfVillagers90
{
    public class BangladeshiFarmerHouse : CompositeShape
    {
        public BangladeshiFarmerHouse(Point top,Point topleft, Point bottomright)
        {
            AddComponent(new Rectangle(topleft, bottomright));
            AddComponent(new TAgle(top, topleft, new Point(bottomright.X, topleft.Y)));
        }
    }
}
