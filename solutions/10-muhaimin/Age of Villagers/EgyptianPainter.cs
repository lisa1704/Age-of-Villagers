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
            Pen pen = new Pen(Color.Green);
            Graphics elem = drawingSpace.CreateGraphics();
            elem.DrawLine(pen, new PointF(x, y), new PointF(x + 8, y + 12));
            elem.DrawLine(pen, new PointF(x, y), new PointF(x - 8, y + 9));

            elem.DrawLine(pen, new PointF(x + 8, y + 12), new PointF(x - 2, y + 16));
            elem.DrawLine(pen, new PointF(x - 8, y + 9), new PointF(x - 2, y + 16));

            elem.DrawLine(pen, new PointF(x, y), new PointF(x - 2, y + 16));
        }

        public override void drawTree(int x, int y)
        {
            Pen pen = new Pen(Color.Green);
            Graphics elem = drawingSpace.CreateGraphics();

            elem.DrawLine(pen, new PointF(x, y), new PointF(x + 4, y - 20));
            elem.DrawLine(pen, new PointF(x, y), new PointF(x - 4, y - 20));

            elem.DrawLine(pen, new PointF(x + 4, y - 20), new PointF(x + 4, y - 24));
            elem.DrawLine(pen, new PointF(x + 4, y - 20), new PointF(x + 8, y - 20));
            elem.DrawLine(pen, new PointF(x + 4, y - 20), new PointF(x + 8, y - 24));

            elem.DrawLine(pen, new PointF(x - 4, y - 20), new PointF(x - 4, y - 24));
            elem.DrawLine(pen, new PointF(x - 4, y - 20), new PointF(x - 8, y - 20));
            elem.DrawLine(pen, new PointF(x - 4, y - 20), new PointF(x - 8, y - 24));
        }

        public override void drawWaterSource(int x, int y)
        {
            Pen pen = new Pen(Color.Green);
            Graphics elem = drawingSpace.CreateGraphics();

            elem.DrawEllipse(pen, x, y, 16, 16);
        }
        public override void paintTerrain()
        {
            base.drawingSpace.BackColor = System.Drawing.Color.Red;
        }
    }
}
