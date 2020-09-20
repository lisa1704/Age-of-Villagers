﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Bangladeshi_Farmers
{
    class BDFarmersWatersource : Composite
    {
        public BDFarmersWatersource(Point Point1)
        {
            Point point2 = new Point(Point1.X - 30, Point1.Y + 55);
            Point point3 = new Point(Point1.X, Point1.Y + 80);
            Point point4 = new Point(Point1.X + 30, Point1.Y + 55);
            Point point5 = new Point(Point1.X + 55, Point1.Y + 80);
            Point point6 = new Point(Point1.X + 80, Point1.Y + 30);
            Point point7 = new Point(Point1.X + 55, Point1.Y);
            Point point8 = new Point(Point1.X + 30, Point1.Y + 30);
            Point point9 = new Point(Point1.X + 30, Point1.Y);

            AddComponent(new Line(Point1, point2));
            AddComponent(new Line(point2, point3));
            AddComponent(new Line(point3, point4));
            AddComponent(new Line(point4, point5));
            AddComponent(new Line(point5, point6));
            AddComponent(new Line(point6, point7));
            AddComponent(new Line(point7, point8));
            AddComponent(new Line(point8, point9));
            AddComponent(new Line(point9, Point1));
        }
    }
}