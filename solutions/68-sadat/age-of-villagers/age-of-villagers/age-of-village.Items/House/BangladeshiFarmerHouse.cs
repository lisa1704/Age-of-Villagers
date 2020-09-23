using age_of_villagers.age_of_villagers.utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace age_of_villagers.age_of_village.Items.House
{
    class BangladeshiFarmerHouse : Ihouse
    {

        public void createHouse(Coordinate coordinate, Panel villageCanvas)
        {
            Pen pen = new Pen(Color.Black);
            Graphics graphics = villageCanvas.CreateGraphics();
            graphics.DrawLine(pen, new PointF(coordinate.X + 8, coordinate.Y - 8), new PointF(coordinate.X, coordinate.Y));
            graphics.DrawLine(pen, new PointF(coordinate.X + 8, coordinate.Y - 8), new PointF(coordinate.X + 16, coordinate.Y));
            graphics.DrawRectangle(pen, coordinate.X, coordinate.Y, 16, 8);
        }
    }
}
