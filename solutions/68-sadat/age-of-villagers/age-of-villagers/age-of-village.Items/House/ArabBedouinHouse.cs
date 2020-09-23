using age_of_villagers.age_of_villagers.utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace age_of_villagers.age_of_village.Items.House
{
    class ArabBedouinHouse : Ihouse
    {
        public void createHouse(Coordinate coordinate, Panel villageCanvas) {
           
            Pen pen = new Pen(Color.Black);
            Graphics graphics = villageCanvas.CreateGraphics();
            graphics.DrawLine(pen, new PointF(coordinate.X, coordinate.Y), new PointF(coordinate.X - 5, coordinate.Y - 10));
            graphics.DrawLine(pen, new PointF(coordinate.X - 5, coordinate.Y - 10), new PointF(coordinate.X - 10, coordinate.Y));
            graphics.DrawLine(pen, new PointF(coordinate.X, coordinate.Y), new PointF(coordinate.X - 10, coordinate.Y));
            graphics.DrawLine(pen, new PointF(coordinate.X - 5, coordinate.Y - 10), new PointF(coordinate.X - 10, coordinate.Y - 10));
            graphics.DrawLine(pen, new PointF(coordinate.X - 10, coordinate.Y), new PointF(coordinate.X - 15, coordinate.Y));
            graphics.DrawLine(pen, new PointF(coordinate.X - 10, coordinate.Y - 10), new PointF(coordinate.X - 15, coordinate.Y));
        }
    }
}
