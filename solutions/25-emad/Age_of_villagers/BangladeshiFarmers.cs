﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_villagers
{
    class BangladeshiFarmers : INations
    {

        Color bg_color = Color.Green;


        public void DrawHouse(Graphics graphics, Point point)
        {
            throw new NotImplementedException();
        }

        public Color DrawBackground()
        {
            return bg_color ;
        }

        public void DrawTree(Graphics graphics, Point point)
        {
            throw new NotImplementedException();
        }

        public void DrawWaterSource(Graphics graphics, Point point)
        {
            Pen pen = new Pen(Color.Black);
           
            
                Point p1 = new Point(point.X - 5, point.Y + 10);
                Point p2 = new Point(point.X, point.Y + 15);
                Point p3 = new Point(point.X + 5, point.Y + 10);
                Point p4 = new Point(point.X + 10, point.Y + 15);
                Point p5 = new Point(point.X + 15, point.Y + 5);
                Point p6 = new Point(point.X + 10, point.Y);
                Point p7 = new Point(point.X + 5, point.Y + 5);
                Point p8 = new Point(point.X + 5, point.Y);
                graphics.DrawLine(pen, point, p1);
                graphics.DrawLine(pen, p1, p2);
                graphics.DrawLine(pen, p2, p3);
                graphics.DrawLine(pen, p3, p4);
                graphics.DrawLine(pen, p4, p5);
                graphics.DrawLine(pen, p5, p6);
                graphics.DrawLine(pen, p6, p7);
                graphics.DrawLine(pen, p7, p8);
                graphics.DrawLine(pen, p8, point); ;
        }

        public string getName()
        {
            throw new NotImplementedException();
        }
    }
}
