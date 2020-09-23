using age_of_villagers.age_of_villagers.utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace age_of_villagers.age_of_villagers.Nations
{
    class InuitHunter : Ination
    {
        Panel villageCanvas;
        public InuitHunter(Panel villageCanvas)
        {
            this.villageCanvas = villageCanvas;
        }
        public void colorTerrain()
        {
            villageCanvas.BackColor = System.Drawing.Color.White;
        }

        public void createHouse(Coordinate coordinate)
        {
            Pen pen = new Pen(Color.Black);
            Graphics graphics = villageCanvas.CreateGraphics();
            float startAngle = 0.0F;
            float sweepAngle = -180.0F;
            graphics.DrawArc(pen, coordinate.X, coordinate.Y, 16, 16, startAngle, sweepAngle);
            graphics.DrawArc(pen, coordinate.X + 4, coordinate.Y + 4, 8, 8, startAngle, sweepAngle);
            graphics.DrawLine(pen, new PointF(coordinate.X, coordinate.Y + 8), new PointF(coordinate.X + 16, coordinate.Y + 8));
        }

        public void createTree(Coordinate coordinate)
        {
            
        }

        public void createWaterSource(Coordinate coordinate)
        {
           
        }
    }
}
