using System.Drawing;

namespace Age_Of_Villagers
{
    public class BangladeshiFarmersTree : CompositeShape
    {



        public BangladeshiFarmersTree(Point location, ItemSize treeSize)


        {
            var top = location;
           

            var baseTopLeft = new Point(top.X + treeSize.width / 2 - treeSize.width / 6, top.Y+ (treeSize.height / 2));
            var baseBottomRight = new Point(top.X+ treeSize.width /2+treeSize.width/6,top.Y+treeSize.height);
            var baseTopRight = new Point(baseBottomRight.X, baseTopLeft.Y);
            var baseBottomLeft = new Point(baseTopLeft.X, baseBottomRight.Y);

            AddComponent(new Arc(top.X,top.Y,treeSize.width,(treeSize.height*2)/3, 0,360));
            AddComponent(new Rectangle(baseTopLeft, baseTopRight, baseBottomLeft, baseBottomRight));


        
           


        }

    }



}
