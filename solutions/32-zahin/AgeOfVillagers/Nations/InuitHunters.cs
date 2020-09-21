﻿using System.Drawing;
using System.Text;
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
        public void DrawHouse(Graphics g, Point point)
        {
            Point p1 = new Point(point.X - 75, point.Y);
            Point p2 = new Point(point.X + 75, point.Y);
            Point p3 = new Point(point.X - 50, point.Y - 50);
            Circle innerCircle = new Circle(g, pen, point, 50, 50, 180, 180);
            innerCircle.DrawShape();
            Circle outerCircle = new Circle(g, pen, p3, 150, 150, 180, 180);
            outerCircle.DrawShape();
            g.DrawLine(pen, p1, p2);
        }

        public void DrawTree(Graphics g, Point point)
        {
            MessageBox.Show("Inuit Hunters can not plant trees");
        }

        public void DrawWaterSource(Graphics g, Point point)
        {
            var message = new StringBuilder();
            MessageBox.Show("Inuit Hunters relies on natural water sources so it is not possible to place water sources");
        }
        public Color DrawTerrain()
        {
            return Color.White;
        }
    }
}
