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
            Pen pen = new Pen(Color.Black);
            Graphics elem = drawingSpace.CreateGraphics();

            elem.DrawLine(pen, new PointF(x + 8, y - 8), new PointF(x, y));
            elem.DrawLine(pen, new PointF(x + 8, y - 8), new PointF(x + 16, y));
            elem.DrawRectangle(pen, x, y, 16, 8);
        }

        public override void drawTree(int x, int y)
        {
            Pen pen = new Pen(Color.Black);
            Graphics elem = drawingSpace.CreateGraphics();

            elem.DrawEllipse(pen, x, y, 16, 16);
            elem.DrawEllipse(pen, x + 7, y + 16, 2, 8);
        }

        public override void drawWaterSource(int x, int y)
        {
            Pen pen = new Pen(Color.Black);
            Graphics elem = drawingSpace.CreateGraphics();
        }
        public override void paintTerrain()
        {
            base.drawingSpace.BackColor = System.Drawing.Color.Green;
        }
    }
}
