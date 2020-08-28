using System.Drawing;

namespace Age_Of_Villagers
{
    public class ArabBeduinTree : CompositeShape
    {



        public ArabBeduinTree(Point location, ItemSize treeSize)
        {
           var  x = location.X+treeSize.width/2;
           var  y = location.Y+treeSize.height;
           var  tree_width = treeSize.width;
           var tree_height = treeSize.height;
           Point p1, p2, p3, p4, p5, mid,p6,p7,p8,p9;

            p1 = new Point(x - tree_width / 2, y - tree_height+ tree_height / 4);
            p2 = new Point(x + tree_width / (2), y - tree_height +tree_height/4);
            p3 = new Point(x + tree_width / (3), y - tree_height+tree_height/12);
            p4 = new Point(x - tree_width / (3), y - tree_height + tree_height / 12);
            p5 = new Point(x , y - tree_height );
            mid = new Point( x , y - tree_height / 2);
            p6 = new Point(mid.X-tree_width/12, y - tree_height / 2);
            p7 = new Point(mid.X + tree_width / 12, y - tree_height / 2);
            p8 = new Point(mid.X - tree_width / 12, y );
            p9 = new Point(mid.X + tree_width / 12, y);


            AddComponent(new Line(mid, p1));
            AddComponent(new Line(mid, p2));
            AddComponent(new Line(mid, p3));
            AddComponent(new Line(mid, p4));
            AddComponent(new Line(mid, p5));
           AddComponent(new Rectangle(p6, p7, p8, p9));
    





            //rectangle.Draw(g, x, y, tree_height / (2), tree_width / 8, 0);

        }

    }



}
