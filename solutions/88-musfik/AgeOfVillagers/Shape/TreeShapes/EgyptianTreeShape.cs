using System.Drawing;

namespace AgeOfVillagers
{
    public class EgyptianTreeShape : CompositeShape
    {
        public EgyptianTreeShape(Point root)
        {
            Point TopLeft = new Point(root.X - 6, root.Y - 20);
            Point TopRight = new Point(root.X + 5, root.Y - 22);

            Point right_branch_root = new Point((int)(root.X + 2.5), root.Y - 11);
            Point right_branch_left = new Point(root.X + 1, root.Y - 24);
            Point right_branch_right = new Point(root.X + 9, root.Y - 20);

            Point left_branch_root = new Point((int)(root.X - 3.9), root.Y - 13);
            Point left_branch_right = new Point(root.X - 2, root.Y - 22);
            Point left_branch_left = new Point(root.X - 9, root.Y - 18);

            AddComponent(new VShape(TopLeft, root, TopRight));
            AddComponent(new VShape(right_branch_left, right_branch_root, right_branch_right));
            AddComponent(new VShape(left_branch_left, left_branch_root, left_branch_right));
        }
    }
}
