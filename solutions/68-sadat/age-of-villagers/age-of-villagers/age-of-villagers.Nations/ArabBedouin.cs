using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using age_of_villagers.age_of_village.Items.House;
using age_of_villagers.age_of_villagers.utilities;

namespace age_of_villagers.age_of_villagrs.Nations
{
    class ArabBedouin : Ination
    {
        ArabBedouinHouse arabBedouinHouse = new ArabBedouinHouse();
        private Panel villageCanvas;

        public ArabBedouin(Panel villageCanvas)
        {
            this.villageCanvas = villageCanvas;
        }

        public void colorTerrain()
        {
            villageCanvas.BackColor = System.Drawing.Color.LightYellow;
        }

        public void createHouse(Coordinate coordinate)
        {
            Pen pen = new Pen(Color.Black);
            Graphics graphics = villageCanvas.CreateGraphics();
            graphics.DrawLine(pen, new PointF(coordinate.X, coordinate.Y), new PointF(coordinate.X - 5, coordinate.Y - 10));
            graphics.DrawLine(pen, new PointF(coordinate.X - 5, coordinate.Y - 10), new PointF(coordinate.X - 10, coordinate.Y));
            graphics.DrawLine(pen, new PointF(coordinate.X, coordinate.Y), new PointF(coordinate.X - 10, coordinate.Y));
            graphics.DrawLine(pen, new PointF(coordinate.X - 5, coordinate.Y - 10), new PointF(coordinate.X - 10, coordinate.Y - 10));
            graphics.DrawLine(pen, new PointF(coordinate.X - 10, coordinate.Y), new PointF(coordinate.X - 15, coordinate.Y));
            graphics.DrawLine(pen, new PointF(coordinate.X - 10, coordinate.Y - 10), new PointF(coordinate.X - 15, coordinate.Y));
        }

        public void createTree(Coordinate coordinate)
        {
            Pen pen = new Pen(Color.Black);
            Graphics elem = villageCanvas.CreateGraphics();
            elem.DrawRectangle(pen,coordinate.X, coordinate.Y, 2, 12);
            elem.DrawLine(pen, new PointF(coordinate.X + 1, coordinate.Y), new PointF(coordinate.X + 1, coordinate.Y - 12));
            elem.DrawLine(pen, new PointF(coordinate.X + 1, coordinate.Y), new PointF(coordinate.X + 4, coordinate.Y - 12));
            elem.DrawLine(pen, new PointF(coordinate.X + 1, coordinate.Y), new PointF(coordinate.X + 6, coordinate.Y - 12));
            elem.DrawLine(pen, new PointF(coordinate.X + 1, coordinate.Y), new PointF(coordinate.X + 8, coordinate.Y - 12));
            elem.DrawLine(pen, new PointF(coordinate.X + 1, coordinate.Y), new PointF(coordinate.X - 3, coordinate.Y - 12));
            elem.DrawLine(pen, new PointF(coordinate.X + 1, coordinate.Y), new PointF(coordinate.X - 5, coordinate.Y - 12));
            elem.DrawLine(pen, new PointF(coordinate.X + 1, coordinate.Y), new PointF(coordinate.X - 7, coordinate.Y - 12));

        }

        public void createWaterSource(Coordinate coordinate)
        {
           

        }
    }
}
