using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_of_Villagers
{
    class BangladeshiPainter : AbstractPainter
    {
        public BangladeshiPainter(Panel panel) : base(panel)
        {
        }
        public override void drawHouse(int x, int y)
        {
            SolidBrush brush = new SolidBrush(Color.Black);
            Graphics elem = drawingSpace.CreateGraphics();
            FontFamily ff = new FontFamily("Arial");
            System.Drawing.Font font = new System.Drawing.Font(ff, 10);
            elem.DrawString("BangladeshiHouse", font, brush, new PointF(x, y));
        }

        public override void drawTree(int x, int y)
        {
            SolidBrush brush = new SolidBrush(Color.Black);
            Graphics elem = base.drawingSpace.CreateGraphics();
            FontFamily ff = new FontFamily("Arial");
            System.Drawing.Font font = new System.Drawing.Font(ff, 10);
            elem.DrawString("BangladeshiTree", font, brush, new PointF(x, y));
        }

        public override void drawWaterSource(int x, int y)
        {
            SolidBrush brush = new SolidBrush(Color.Black);
            Graphics elem = base.drawingSpace.CreateGraphics();
            FontFamily ff = new FontFamily("Arial");
            System.Drawing.Font font = new System.Drawing.Font(ff, 10);
            elem.DrawString("BangladeshiWaterSource", font, brush, new PointF(x, y));
        }
    }
}
