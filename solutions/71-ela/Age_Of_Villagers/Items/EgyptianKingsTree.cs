using System.Drawing;

namespace Age_Of_Villagers
{
    public class EgyptianKingsTree : CompositeShape
    {
        







        public EgyptianKingsTree(Point location,ItemSize treeSize)
        {
            Point bottom = new Point(location.X, location.Y + treeSize.height);
            Point midLeft = new Point(location.X -(treeSize.width/ 2)+2, location.Y );
            Point midRight = new Point(location.X +( treeSize.width / 2)-2, location.Y);
            Point left_1 = new Point(location.X - 8, location.Y);
            Point left_2 = new Point(location.X + 2, location.Y);
            Point right_1 = new Point(location.X - 2, location.Y);
            Point right_2 = new Point(location.X + 8, location.Y);
            
          





            AddComponent(new EgyptianKingsTreePartSymmetric(bottom,midRight,left_2,right_2,treeSize.height/4,treeSize.width/4));
            AddComponent(new EgyptianKingsTreePartSymmetric(bottom, midLeft,left_1,right_1, treeSize.height / 4, treeSize.width / 8));
        



        }

    }



}
