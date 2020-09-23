using age_of_villagers.age_of_villagers.utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace age_of_villagers.age_of_villagers.Nations
{
    class BangladeshiFarmer : Ination
    {
        Panel villageCanvas;
        public BangladeshiFarmer(Panel villageCanvas)
        {
            this.villageCanvas = villageCanvas;
        }
        public void colorTerrain()
        {
            villageCanvas.BackColor = System.Drawing.Color.Green;
        }

        public void createHouse(Coordinate coordinate)
        {
            Pen pen = new Pen(Color.Black);
            Graphics graphics = villageCanvas.CreateGraphics();
            graphics.DrawLine(pen, new PointF(coordinate.X + 8, coordinate.Y - 8), new PointF(coordinate.X, coordinate.Y));
            graphics.DrawLine(pen, new PointF(coordinate.X + 8, coordinate.Y - 8), new PointF(coordinate.X + 16, coordinate.Y));
            graphics.DrawRectangle(pen, coordinate.X, coordinate.Y, 16, 8);
        }

        public void createTree(Coordinate coordinate)
        {
            Pen pen = new Pen(Color.Black);
            Graphics graphics = villageCanvas.CreateGraphics();
            graphics.DrawEllipse(pen, coordinate.X, coordinate.Y, 16, 16);
            graphics.DrawEllipse(pen, coordinate.X + 7, coordinate.Y + 16, 2, 8);
        }

        public void createWaterSource(Coordinate coordinate)
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
