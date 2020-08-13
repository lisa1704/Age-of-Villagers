using System.Drawing;

namespace Age_Of_Villagers
{
    public class BangladeshiFarmersTree : CompositeShape
    {



        public BangladeshiFarmersTree(Point location, ItemSize treeSize)


        {
            var top = location;
           

            var baseTopLeft = new Point(location.X,top.Y);
            var baseBottomRight = new Point(treeSize.width/4, treeSize.height);
            var baseTopRight = new Point(baseBottomRight.X, baseTopLeft.Y);
            var baseBottomLeft = new Point(baseTopLeft.X, baseBottomRight.Y);

            AddComponent(new Arc(top.X,top.Y,treeSize.width,treeSize.height/(3*2),0,360));
            AddComponent(new Rectangle(baseTopLeft, baseTopRight, baseBottomLeft, baseBottomRight));


        
           


        }

    }



}
