using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Components
{
    public interface IComponent
    {
        void Draw(Graphics g);

    }

    public class Line:IComponent
    {
        public int x1, y1, x2, y2;
        public Point p1, p2;

        public Line(int x1,int y1,int x2,int y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
        }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            g.DrawLine(pen, x1, y1, x2, y2);
        }
    }

    public class Arc : IComponent
    {
        public int x, y, width, height, startAngle, sweepAngle;

        public Arc(int x,int y,int width,int height,int startAngle,int sweepAngle)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.startAngle = startAngle;
            this.sweepAngle = sweepAngle;
        }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black);

            g.DrawArc(pen, x, y,width,height,startAngle,sweepAngle);
        }
    }

    public class CompositeShape:IComponent
    {
        public List<IComponent> components;

        public CompositeShape()
        {
            components = new List<IComponent>();
        }

        public void AddComponent(IComponent component)
        {
            components.Add(component);
        }

        public void Draw(Graphics g)
        {
            foreach (var component in components)
                component.Draw(g);
        }
    }

    public class Rectangle:CompositeShape
    {
        public Point topLeft, topRight, bottomLeft, bottomRight;

        public Rectangle(Point topLeft, Point topRight, Point bottomLeft, Point bottomRight)
        {
            this.topLeft = topLeft;
            this.topRight = topRight;
            this.bottomLeft = bottomLeft;
            this.bottomRight = bottomRight;

            AddComponent(new Line(topLeft.X, topLeft.Y, topRight.X, topRight.Y));
            AddComponent(new Line(topLeft.X, topLeft.Y, bottomLeft.X, bottomLeft.Y));
            AddComponent(new Line(bottomLeft.X, bottomLeft.Y, bottomRight.X, bottomRight.Y));
            AddComponent(new Line(bottomRight.X, bottomRight.Y, topRight.X, topRight.Y));
        }
    }

    public class Triangle:CompositeShape
    {
        public Point top, left, right;

        public Triangle(Point top, Point left, Point right)
        {
            this.top = top;
            this.left = left;
            this.right = right;

            AddComponent(new Line(top.X, top.Y, left.X, left.Y));
            AddComponent(new Line(left.X, left.Y, right.X, right.Y));
            AddComponent(new Line(right.X, right.Y, top.X, top.Y));
        }
    }
}
