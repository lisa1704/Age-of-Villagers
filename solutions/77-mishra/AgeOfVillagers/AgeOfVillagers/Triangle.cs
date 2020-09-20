using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class Triangle : IShape
    {
        private Point p1;
        private Point p2;
        private Point p3;

        public Triangle(Point p1, Point p2, Point p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
        }

        private CompositeShapes cshape = new CompositeShapes();

        public void createTriangle()
        {
            cshape.addshapes(new Line(p1, p2));
            cshape.addshapes(new Line(p1, p3));
            cshape.addshapes(new Line(p2, p3));
        }
        public void draw(Point p, Panel drawingBoard)
        {
            Graphics g = drawingBoard.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            createTriangle();
            cshape.draw(p, drawingBoard);

        }
    }
}
