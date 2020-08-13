﻿using System.Drawing;

namespace Age_Of_Villagers
{
    public class Line : IShapes
    {
        Point point1, point2;

        public Line(Point point1, Point point2)
        {
            this.point1 = point1;
            this.point2 = point2;
        }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            g.DrawLine(pen, point1, point2);
        }

       

        public Rectangle GetBBox()
        {
            throw new System.NotImplementedException();
        }
    }



}
