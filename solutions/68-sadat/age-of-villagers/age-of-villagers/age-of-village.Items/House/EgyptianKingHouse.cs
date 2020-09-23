using age_of_villagers.age_of_villagers.utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace age_of_villagers.age_of_village.Items.House
{
    class EgyptianKingHouse : Ihouse
    {

        public void createHouse(Coordinate coordinate, Panel villageCanvas)
        {
            Pen pen = new Pen(Color.Black);
            Graphics graphics = villageCanvas.CreateGraphics();
            graphics.DrawLine(pen, new PointF(coordinate.X, coordinate.Y), new PointF(coordinate.X + 8, coordinate.Y + 12));
            graphics.DrawLine(pen, new PointF(coordinate.X, coordinate.Y), new PointF(coordinate.X - 8, coordinate.Y + 9));
            graphics.DrawLine(pen, new PointF(coordinate.X + 8, coordinate.Y + 12), new PointF(coordinate.X - 2, coordinate.Y + 16));
            graphics.DrawLine(pen, new PointF(coordinate.X - 8, coordinate.Y + 9), new PointF(coordinate.X - 2, coordinate.Y + 16));
            graphics.DrawLine(pen, new PointF(coordinate.X, coordinate.Y), new PointF(coordinate.X - 2, coordinate.Y + 16));
        }
    }
}
