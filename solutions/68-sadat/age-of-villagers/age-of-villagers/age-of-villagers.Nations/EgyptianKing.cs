using age_of_villagers.age_of_villagers.utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace age_of_villagers.age_of_villagers.Nations
{
    class EgyptianKing : Ination
    {
        Panel villageCanvas;
        public EgyptianKing(Panel villageCanvas)
        {
            this.villageCanvas = villageCanvas;
        }
        public void colorTerrain()
        {
            villageCanvas.BackColor = System.Drawing.Color.Yellow;
        }

        public void createHouse(Coordinate coordinate)
        {

            Pen pen = new Pen(Color.Black);
            Graphics graphics = villageCanvas.CreateGraphics();
            graphics.DrawLine(pen, new PointF(coordinate.X, coordinate.Y), new PointF(coordinate.X + 8, coordinate.Y + 12));
            graphics.DrawLine(pen, new PointF(coordinate.X, coordinate.Y), new PointF(coordinate.X - 8, coordinate.Y + 9));
            graphics.DrawLine(pen, new PointF(coordinate.X + 8, coordinate.Y + 12), new PointF(coordinate.X - 2, coordinate.Y + 16));
            graphics.DrawLine(pen, new PointF(coordinate.X - 8, coordinate.Y + 9), new PointF(coordinate.X - 2, coordinate.Y + 16));
            graphics.DrawLine(pen, new PointF(coordinate.X, coordinate.Y), new PointF(coordinate.X - 2, coordinate.Y + 16));
        }

        public void createTree(Coordinate coordinate)
        {
            Pen pen = new Pen(Color.Black);
            Graphics graphics = villageCanvas.CreateGraphics();

            graphics.DrawLine(pen, new PointF(coordinate.X, coordinate.Y), new PointF(coordinate.X + 4, coordinate.Y - 20));
            graphics.DrawLine(pen, new PointF(coordinate.X, coordinate.Y), new PointF(coordinate.X - 4, coordinate.Y - 20));
            graphics.DrawLine(pen, new PointF(coordinate.X + 4, coordinate.Y - 20), new PointF(coordinate.X + 4, coordinate.Y - 24));
            graphics.DrawLine(pen, new PointF(coordinate.X + 4, coordinate.Y - 20), new PointF(coordinate.X + 8, coordinate.Y - 20));
            graphics.DrawLine(pen, new PointF(coordinate.X + 4, coordinate.Y - 20), new PointF(coordinate.X + 8, coordinate.Y - 24));
            graphics.DrawLine(pen, new PointF(coordinate.X - 4, coordinate.Y - 20), new PointF(coordinate.X - 4, coordinate.Y - 24));
            graphics.DrawLine(pen, new PointF(coordinate.X - 4, coordinate.Y - 20), new PointF(coordinate.X - 8, coordinate.Y - 20));
            graphics.DrawLine(pen, new PointF(coordinate.X - 4, coordinate.Y - 20), new PointF(coordinate.X - 8, coordinate.Y - 24));

        }

        public void createWaterSource(Coordinate coordinate)
        {
            Pen pen = new Pen(Color.Black);
            Graphics graphics = villageCanvas.CreateGraphics();
            graphics.DrawEllipse(pen, coordinate.X, coordinate.Y, 12, 12);

        }
    }
}
