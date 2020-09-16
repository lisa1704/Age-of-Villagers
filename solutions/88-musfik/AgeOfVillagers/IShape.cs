using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    public interface IShape
    {
        void Draw(Graphics g, Pen p);
    }

    public class Line : IShape
    {
        private readonly Point point1, point2;
        public Line(Point p1, Point p2)
        {
            point1 = p1;
            point2 = p2;
        }

        public void Draw(Graphics g, Pen p)
        {
            g.DrawLine(p, point1, point2);
        }
    }

    public class Arc : IShape
    {
        private readonly Point _topLeft, _bottomRight;
        private readonly float _startAngle, _endAngle;
        private int width, height;
        public Arc(Point topLeft, Point bottomRight, float startAngle, float endAngle)
        {
            _topLeft = topLeft;
            _bottomRight = bottomRight;
            _startAngle = startAngle;
            _endAngle = endAngle;

            width = Math.Abs(bottomRight.X - topLeft.X);
            height = Math.Abs(bottomRight.Y - topLeft.Y);
        }

        public void Draw(Graphics g, Pen p)
        {
            g.DrawArc(p, _topLeft.X, _topLeft.Y, width, height, _startAngle, _endAngle);
        }
    }


    public class NullShape : IShape
    {
        public NullShape(Point point)
        {
        }

        public void Draw(Graphics g, Pen p)
        {
            //No drawing event       
        }
    }

    public abstract class CompositeShape : IShape
    {
        private readonly List<IShape> components;
        protected CompositeShape()
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

    public class Rectangle : CompositeShape
    {
        public Rectangle (Point topLeft, Point bottomRight)
        {
            var topRight = new Point(bottomRight.X, topLeft.Y);
            var bottomLeft = new Point(topLeft.X, bottomRight.Y);

            AddComponent(new Line(topLeft, topRight));
            AddComponent(new Line(topRight, bottomRight));
            AddComponent(new Line(bottomRight, bottomLeft));
            AddComponent(new Line(bottomLeft, topLeft));
        }
        public Rectangle(Point topLeft, Point topRight ,Point bottomRight, Point bottomLeft)
        {
            AddComponent(new Line(topLeft, topRight));
            AddComponent(new Line(topRight, bottomRight));
            AddComponent(new Line(bottomRight, bottomLeft));
            AddComponent(new Line(bottomLeft, topLeft));
        }
    }

    public class VShape : CompositeShape
    {
        public VShape(Point p1, Point mid_p2, Point p3)
        {
            AddComponent(new Line(p1, mid_p2));
            AddComponent(new Line(mid_p2, p3));
        }
    }

}
