using System;
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

    public class NoWaterResource : VillageItem
    {
        private readonly Point point;

        public NoWaterResource(Point point)
        {
            this.point = point;
        }

        public override void Draw(Graphics g, Pen p)
        {
            
        }

        public override Point GetPoint()
        {
            return point;
        }
    }

    public class NoTree : VillageItem
    {
        private readonly Point point;

        public NoTree(Point point)
        {
            this.point = point;
        }

        public override void Draw(Graphics g, Pen p)
        {

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
        private readonly float x;
        private readonly float y;
        private readonly float width;
        private readonly float height;
        private readonly float startAngle;
        private readonly float sweepAngle;

        public MyArc(float x, float y, float width, float height, float startAngle, float sweepAngle)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.startAngle = startAngle;
            this.sweepAngle = sweepAngle;
        }

        public void Draw(Graphics g, Pen p)
        {
            g.DrawArc(p, x, y, width, height, startAngle, sweepAngle);
        }
    }

    public class Ellipse : Shape
    {
        private readonly Point _topleft;
        private readonly Point _bottomright;

        public Ellipse(Point topleft, Point bottomright)
        {
            _topleft = topleft;
            _bottomright = bottomright;
            AddComponent(new MyArc(_topleft.X,_topleft.Y, _bottomright.X-_topleft.X , _bottomright.Y-_topleft.Y ,0,360));
        }
    }

    public class HalfCircle : Shape
    {
        private readonly Point _topleft;
        private readonly Point _bottomright;

        public HalfCircle(Point topleft, Point bottomright)
        {
            _topleft = topleft;
            _bottomright = bottomright;
            AddComponent(new MyArc(_topleft.X, _topleft.Y, _bottomright.X - _topleft.X, (_bottomright.Y - _topleft.Y) * 2, 180, 180));
        }
    }

    public class VShape : Shape
    {
        private readonly Point _point1;
        private readonly Point _middlepoint;
        private readonly Point _point2;

        public VShape(Point point1, Point middlepoint, Point point2)
        {
            _point1 = point1;
            _middlepoint = middlepoint;
            _point2 = point2;
            AddComponent(new MyLine(_point1, _middlepoint));
            AddComponent(new MyLine(_middlepoint, _point2));
        }
    }

    public class Quadrilateral : Shape
    {
        private readonly Point _point1;
        private readonly Point _point2;
        private readonly Point _point3;
        private readonly Point _point4;

        public Quadrilateral(Point point1, Point point2, Point point3, Point point4)
        {
            _point1 = point1;
            _point2 = point2;
            _point3 = point3;
            _point4 = point4;
            AddComponent(new MyLine(_point1, _point2));
            AddComponent(new MyLine(_point2, _point3));
            AddComponent(new MyLine(_point3, _point4));
            AddComponent(new MyLine(_point4, _point1));
        }
    }

}
