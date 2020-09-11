using System.Collections.Generic;
using System.Drawing;

namespace AgeOfVillagers
{
    public interface IShape
    {
        void Draw(Graphics g, Pen p);
    }

    public abstract class Shape : IShape
    {
        private readonly List<IShape> components;
        protected Shape()
        {
            components = new List<IShape>();
        }
        protected void AddComponent(IShape shape)
        {
            components.Add(shape);
        }

        public void Draw(Graphics g, Pen p)
        {
            foreach (IShape item in components)
            {
                item.Draw(g, p);
            }
        }
    }

    public abstract class VillageItem : IShape
    {
        public abstract void Draw(Graphics g, Pen p);
        public abstract Point GetPoint();
        
    }
    public class Sampletree : VillageItem
    {
        private readonly Point point;

        public Sampletree(Point point)
        {
            this.point = point;
        }

        public override void Draw(Graphics g, Pen p)
        {
            g.DrawLine(p,point,new Point(point.X,point.Y-50));
        }

        public override Point GetPoint()
        {
            return point;
        }
    }
    public class SampleHouse : VillageItem
    {
        private readonly Point point;

        public SampleHouse(Point point)
        {
            this.point = point;
        }

        public override void Draw(Graphics g, Pen p)
        {
            g.DrawLine(p, point, new Point(point.X + 50, point.Y - 50));
        }

        public override Point GetPoint()
        {
            return point;
        }
    }
    public class SampleWaterResource : VillageItem
    {
        private readonly Point point;

        public SampleWaterResource(Point point)
        {
            this.point = point;
        }

        public override void Draw(Graphics g, Pen p)
        {
            g.DrawLine(p, point, new Point(point.X + 50, point.Y));
        }

        public override Point GetPoint()
        {
            return point;
        }
    }

    public class MyRectangle : Shape
    {
        private readonly Point _topleft;
        private readonly Point _bottomright;

        public MyRectangle(Point topleft, Point bottomright)
        {
            _topleft = topleft;
            _bottomright = bottomright;
            AddComponent(new MyLine(_topleft, new Point(_bottomright.X, _topleft.Y)));
            AddComponent(new MyLine(_topleft, new Point(_topleft.X, _bottomright.Y)));
            AddComponent(new MyLine(new Point(_bottomright.X, _topleft.Y), _bottomright));
            AddComponent(new MyLine(new Point(_topleft.X, _bottomright.Y), _bottomright));
        }


    }

    public class MyTriangle : Shape
    {
        private readonly Point _top;
        private readonly Point _bottomleft;
        private readonly Point _bottomright;

        public MyTriangle(Point top, Point bottomleft, Point bottomright)
        {
            _top = top;
            _bottomright = bottomright;
            _bottomleft = bottomleft;
            AddComponent(new MyLine(_top, _bottomleft));
            AddComponent(new MyLine(_top, _bottomright));
            AddComponent(new MyLine(_bottomleft, _bottomright));
        }

    }

    public class BangladeshiHouseShape : Shape
    {
        private readonly Point _top;
        private readonly Point _middleleft;
        private readonly Point _bottomright;

        public BangladeshiHouseShape(Point top, Point middleleft, Point bottomright)
        {
            _top = top;
            _bottomright = bottomright;
            _middleleft = middleleft;
            AddComponent(new MyTriangle(_top, _middleleft, new Point(_bottomright.X, _middleleft.Y)));
            AddComponent(new MyRectangle(_middleleft, _bottomright));
        }

    }

    public class MyLine : IShape
    {
        private readonly Point point1;
        private readonly Point point2;

        public MyLine(Point point1, Point point2)
        {
            this.point1 = point1;
            this.point2 = point2;
        }

        public void Draw(Graphics g, Pen p)
        {
            g.DrawLine(p, point1, point2);
        }
    }
    public class MyArc : IShape
    {

        public MyArc()
        {

        }

        public void Draw(Graphics g, Pen p)
        {
            
        }
    }
}
