using age_of_villagers.age_of_villagers.utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace age_of_villagers.age_of_village.Items.House
{
    class InuitHunterHouse : Ihouse
    {
       
        public void createHouse(Coordinate coordinate, Panel villageCanvas)
        {
            Pen pen = new Pen(Color.Black);
            Graphics graphics = villageCanvas.CreateGraphics();
            float startAngle = 0.0F;
            float sweepAngle = -180.0F;
            graphics.DrawArc(pen, coordinate.X, coordinate.Y, 16, 16, startAngle, sweepAngle);
            graphics.DrawArc(pen, coordinate.X + 4, coordinate.Y + 4, 8, 8, startAngle, sweepAngle);
            graphics.DrawLine(pen, new PointF(coordinate.X, coordinate.Y + 8), new PointF(coordinate.X + 16, coordinate.Y + 8));
        }
    }
}
