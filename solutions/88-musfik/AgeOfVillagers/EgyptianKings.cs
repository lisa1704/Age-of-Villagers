using System;
using System.Drawing;

namespace AgeOfVillagers
{
    public class EgyptianKings : INation
    {
        private readonly Color color;
        private readonly String nation_name;

        public EgyptianKings()
        {
            color = Color.Yellow;
            nation_name = "Egyptian Kings";
        }

        public object getHouse(Point point)
        {
            throw new NotImplementedException();
        }

        public string getNationName()
        {
            return nation_name;
        }

        public Color getTerrainColor()
        {
            return color;
        }

        public object getTree(Point point)
        {
            throw new NotImplementedException();
        }

        public object getWaterResource(Point point)
        {
            throw new NotImplementedException();
        }
    }

    public class EgyptianKingsHouse : CompositeShape
    {
        public EgyptianKingsHouse(Point selectedPoint)
        {
            Point top = new Point(selectedPoint.X - 4, selectedPoint.Y - 6);
            Point base_left = new Point(selectedPoint.X - 10, selectedPoint.Y + 8);
            Point base_mid = new Point(selectedPoint.X + 0, selectedPoint.Y + 10);
            Point base_right = new Point(selectedPoint.X + 6, selectedPoint.Y + 2);

            AddComponent(new VShape(top , base_left, base_mid));
            AddComponent(new VShape(top, base_right, base_mid));
            AddComponent(new Line(top, base_mid));
        }
    }
    public class EgyptianKingsTree : CompositeShape
    {
        public EgyptianKingsTree(Point root)
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

    public class EgyptianKings_WaterResource : CompositeShape
    {
        public EgyptianKings_WaterResource(Point root)
        {
        }
    }
}
