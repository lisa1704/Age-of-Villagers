﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgeOfVillagers.Shapes;

namespace AgeOfVillagers
{
    public class InuitHunters : INation
    {
        Pen pen = new Pen(Color.Black);
        public InuitHunters()
        {

        }
        public string DrawHouse(Graphics g, Point point)
        {
            Point p1 = new Point(point.X - 75, point.Y);
            Point p2 = new Point(point.X + 75, point.Y);
            Point p3 = new Point(point.X - 50, point.Y - 50);
            Circle innerCircle = new Circle(g, pen, point, 50, 50, 180, 180);
            innerCircle.DrawShape();
            Circle outerCircle = new Circle(g, pen, p3, 150, 150, 180, 180);
            outerCircle.DrawShape();
            g.DrawLine(pen, p1, p2);

            return "Inuit House";
        }

        public string DrawTree(Graphics g, Point point)
        {
            MessageBox.Show("Inuit Hunters can not plant trees");

            return "Inuit Hunters can not plant trees";
        }

        public string DrawWaterSource(Graphics g, Point point)
        {
            var message = new StringBuilder();
            MessageBox.Show("Inuit Hunters relies on natural water sources so it is not possible to place water sources");
            return "Inuit Hunters relies on natural water sources so it is not possible to place water sources";
        }
        public Color DrawTerrain()
        {
            return Color.White;
        }
    }
}
