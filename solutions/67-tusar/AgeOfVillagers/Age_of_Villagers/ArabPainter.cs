using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_of_Villagers
{
    class ArabPainter : AbstractPainter
    {
        public ArabPainter(Panel panel) : base(panel)
        {
        }
        public override void drawHouse(int x, int y)
        {
            SolidBrush brush = new SolidBrush(Color.Blue);
            Graphics elem = base.drawingSpace.CreateGraphics();
            FontFamily ff = new FontFamily("Arial");
            System.Drawing.Font font = new System.Drawing.Font(ff, 10);
            elem.DrawString("ArabHouse", font, brush, new PointF(x, y));
        }

        public override void drawTree(int x, int y)
        {
            SolidBrush brush = new SolidBrush(Color.Blue);
            Graphics elem = base.drawingSpace.CreateGraphics();
            FontFamily ff = new FontFamily("Arial");
            System.Drawing.Font font = new System.Drawing.Font(ff, 10);
            elem.DrawString("ArabTree", font, brush, new PointF(x, y));
        }

        public override void drawWaterSource(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}
