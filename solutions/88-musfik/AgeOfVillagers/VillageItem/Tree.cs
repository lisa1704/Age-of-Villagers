using System.Drawing;

namespace AgeOfVillagers
{
    public abstract class Tree : IVillageItem
    {
        private readonly Point point;
        public Tree(Point point)
        {
            this.point = point;
            getItemShape(point);
        }
        public Point getItemLocation()
        {
            return point;
        }
        public abstract CompositeShape getItemShape(Point point);
    }
    


}
