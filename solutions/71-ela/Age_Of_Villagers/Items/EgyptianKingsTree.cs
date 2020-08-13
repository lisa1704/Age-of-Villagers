using System.Drawing;

namespace Age_Of_Villagers
{
    public class EgyptianKingsTree : CompositeShape
    {
        







        public EgyptianKingsTree(Point location,ItemSize treeSize)
        {
            Point midLeft = new Point(location.X -treeSize.width/ 3, location.Y + treeSize.height / 2);
            Point midRight = new Point(location.X + treeSize.width / 3, location.Y + treeSize.height / 2);
            Point bottom = new Point(location.X, location.Y + treeSize.height);
          





            AddComponent(new EgyptianKingsTreePartSymmetric(bottom,midRight,treeSize.height/2,treeSize.width/2));
            AddComponent(new EgyptianKingsTreePartSymmetric(bottom, midLeft, treeSize.height / 2, treeSize.width / 2));
        



        }

    }



}
