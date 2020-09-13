using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers90
{
    class Rectangle : CompositeShape
    {
        private readonly Point TopLeft;
        private readonly Point BottomRight;
        public Rectangle(Point topLeft, Point BottomRight)
        {
            var TopRight = new Point(BottomRight.X, topLeft.Y);
            var BottomLeft = new Point(topLeft.X, BottomRight.Y);

            AddComponent(new Line(topLeft, BottomLeft));
            AddComponent(new Line(topLeft, TopRight));
            AddComponent(new Line(BottomLeft, BottomRight));
            AddComponent(new Line(BottomRight, TopRight));
        }

       
        /*public void Draw(Graphics g)
        {
            var pen = new Pen(Color.Black, 1);
            g.DrawLine(pen, TopLeft.X, TopLeft.Y, BottomRight.X, TopLeft.Y);
            g.DrawLine(pen, TopLeft.X, TopLeft.Y, TopLeft.X, BottomRight.Y);
            g.DrawLine(pen, TopLeft.X, BottomRight.Y, BottomRight.X, BottomRight.Y);
            g.DrawLine(pen, BottomRight.X, TopLeft.Y, BottomRight.X, BottomRight.Y);
        }*/


    }
}
