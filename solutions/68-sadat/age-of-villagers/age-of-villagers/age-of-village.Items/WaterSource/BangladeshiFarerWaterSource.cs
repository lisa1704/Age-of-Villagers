using age_of_villagers.age_of_villagers.utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace age_of_villagers.age_of_village.Items.WaterSource
{
    class BangladeshiFarerWaterSource : IwaterSource
    {
        

        public void createWaterSource(Coordinate coordinate, Panel villageCanvas)
        {
            Pen pen = new Pen(Color.Black);
            Graphics graphics = villageCanvas.CreateGraphics();
            graphics.DrawLine(pen, new PointF(coordinate.X, coordinate.Y), new PointF(coordinate.X - 3, coordinate.Y - 3));
            graphics.DrawLine(pen, new PointF(coordinate.X - 3, coordinate.Y - 3), new PointF(coordinate.X - 6, coordinate.Y + 5));
            graphics.DrawLine(pen, new PointF(coordinate.X - 6, coordinate.Y + 5), new PointF(coordinate.X - 12, coordinate.Y - 1));
            graphics.DrawLine(pen, new PointF(coordinate.X - 12, coordinate.Y - 1), new PointF(coordinate.X - 24, coordinate.Y + 6));
            graphics.DrawLine(pen, new PointF(coordinate.X - 24, coordinate.Y + 6), new PointF(coordinate.X - 13, coordinate.Y + 24));
            graphics.DrawLine(pen, new PointF(coordinate.X - 13, coordinate.Y + 24), new PointF(coordinate.X, coordinate.Y + 10));
            graphics.DrawLine(pen, new PointF(coordinate.X, coordinate.Y + 10), new PointF(coordinate.X, coordinate.Y));
        }
    }
}
