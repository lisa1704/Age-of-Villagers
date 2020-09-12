using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_of_Villagers
{
    class EgyptianPainter : AbstractPainter
    {
        public EgyptianPainter(Panel panel) : base(panel)
        {
        }
        public override void drawHouse(int x, int y)
        {
            SolidBrush brush = new SolidBrush(Color.Green);
            Graphics elem = drawingSpace.CreateGraphics();
            FontFamily ff = new FontFamily("Arial");
            System.Drawing.Font font = new System.Drawing.Font(ff, 10);
            elem.DrawString("EgyptianHouse", font, brush, new PointF(x, y));
        }

        public override void drawTree(int x, int y)
        {
            SolidBrush brush = new SolidBrush(Color.Green);
            Graphics elem = base.drawingSpace.CreateGraphics();
            FontFamily ff = new FontFamily("Arial");
            System.Drawing.Font font = new System.Drawing.Font(ff, 10);
            elem.DrawString("EgyptianTree", font, brush, new PointF(x, y));
        }

        public override void drawWaterSource(int x, int y)
        {
            Pen pen = new Pen(Color.Black);
            Graphics elem = drawingSpace.CreateGraphics();

            elem.DrawEllipse(pen, x, y, 16, 16);
        }
        public override void paintTerrain()
        {
            base.drawingSpace.BackColor = System.Drawing.Color.Yellow;
        }
    }
}
