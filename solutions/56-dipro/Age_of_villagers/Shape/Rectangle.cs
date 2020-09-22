using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Age_of_villagers.Shape
{
    class Rectangle : IShape
    {
        private readonly Point top_left;
        private readonly Point top_right;
        private readonly Point bottom_left;
        private readonly Point bottom_right;

        public Rectangle(Point top_left, Point bottom_right)
        {
            this.top_left = top_left;
            this.top_right = new Point(bottom_right.X, top_left.Y);
            this.bottom_left = new Point(top_left.X, bottom_right.Y);
            this.bottom_right = bottom_right;
        }

        public void draw(Graphics g, Pen p)
        {
            new Line(top_left, top_right).draw(g, p);
            new Line(top_left, bottom_left).draw(g, p);
            new Line(bottom_left, bottom_right).draw(g, p);
            new Line(bottom_right, top_right).draw(g, p);
        }
    }
}
