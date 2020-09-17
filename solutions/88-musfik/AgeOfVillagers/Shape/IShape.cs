using System;
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

}
