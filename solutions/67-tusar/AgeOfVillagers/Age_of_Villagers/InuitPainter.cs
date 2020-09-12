using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_of_Villagers
{
    class InuitPainter : AbstractPainter
    {
        public InuitPainter(Panel panel) : base(panel)
        {
        }
        public override void drawHouse(int x, int y)
        {
            SolidBrush brush = new SolidBrush(Color.Red);
            Graphics elem = drawingSpace.CreateGraphics();
            FontFamily ff = new FontFamily("Arial");
            System.Drawing.Font font = new System.Drawing.Font(ff, 10);
            elem.DrawString("InuitHouse", font, brush, new PointF(x, y));
        }

        public override void drawTree(int x, int y)
        {
            throw new NotImplementedException();
        }

        public override void drawWaterSource(int x, int y)
        {
            throw new NotImplementedException();
        }
        public override void paintTerrain()
        {
            base.drawingSpace.BackColor = System.Drawing.Color.White;
        }
    }
}
