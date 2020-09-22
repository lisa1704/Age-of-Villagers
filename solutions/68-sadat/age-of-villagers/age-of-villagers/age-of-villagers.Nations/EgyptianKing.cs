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

        public void createHouse(int x, int y)
        {
            SolidBrush brush = new SolidBrush(Color.Black);
            Graphics graphics = villageCanvas.CreateGraphics();
            FontFamily ff = new FontFamily("Arial");
            System.Drawing.Font font = new System.Drawing.Font(ff, 10);
            graphics.DrawString("EgyptianKingHouse", font, brush, new PointF(x, y));
        }

        public void createTree(int x, int y)
        {
            SolidBrush brush = new SolidBrush(Color.Black);
            Graphics graphics = villageCanvas.CreateGraphics();
            FontFamily ff = new FontFamily("Arial");
            System.Drawing.Font font = new System.Drawing.Font(ff, 10);
            graphics.DrawString("EgyptianKingTree", font, brush, new PointF(x, y));
        }

        public void createWaterSource(int x, int y)
        {
            SolidBrush brush = new SolidBrush(Color.Black);
            Graphics graphics = villageCanvas.CreateGraphics();
            FontFamily ff = new FontFamily("Arial");
            System.Drawing.Font font = new System.Drawing.Font(ff, 10);
            graphics.DrawString("EgyptianKingWaterSource", font, brush, new PointF(x, y));
        }
    }
}
