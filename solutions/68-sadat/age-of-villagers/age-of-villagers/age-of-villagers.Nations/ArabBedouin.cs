using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using age_of_villagers.age_of_village.Items.House;

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

        public void createHouse(int x, int y)
        {
            Pen pen = new Pen(Color.Black);
            Graphics graphics = villageCanvas.CreateGraphics();
            graphics.DrawLine(pen, new PointF(x, y), new PointF(x - 5, y - 10));
            graphics.DrawLine(pen, new PointF(x - 5, y - 10), new PointF(x - 10, y));
            graphics.DrawLine(pen, new PointF(x, y), new PointF(x - 10, y));
            graphics.DrawLine(pen, new PointF(x - 5, y - 10), new PointF(x - 10, y - 10));
            graphics.DrawLine(pen, new PointF(x - 10, y), new PointF(x - 15, y));
            graphics.DrawLine(pen, new PointF(x - 10, y - 10), new PointF(x - 15, y));
        }

        public void createTree(int x, int y)
        {
            SolidBrush brush = new SolidBrush(Color.Blue);
            Graphics graphics = villageCanvas.CreateGraphics();
            FontFamily ff = new FontFamily("Arial");
            System.Drawing.Font font = new System.Drawing.Font(ff, 10);
            graphics.DrawString("ArabTree", font, brush, new PointF(x, y));

        }

        public void createWaterSource(int x, int y)
        {
            SolidBrush brush = new SolidBrush(Color.Blue);
            Graphics graphics = villageCanvas.CreateGraphics();
            FontFamily ff = new FontFamily("Arial");
            System.Drawing.Font font = new System.Drawing.Font(ff, 10);
            graphics.DrawString("ArabWaterSource", font, brush, new PointF(x, y));

        }
    }
}
