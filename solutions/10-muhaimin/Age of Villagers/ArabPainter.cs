using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
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
            Pen pen = new Pen(Color.Black);
            Graphics elem = drawingSpace.CreateGraphics();

            //draw triangle
            elem.DrawLine(pen, new PointF(x, y), new PointF(x - 4, y - 8));
            elem.DrawLine(pen, new PointF(x - 4, y - 8), new PointF(x - 8, y));
            elem.DrawLine(pen, new PointF(x, y), new PointF(x - 8, y));

            //draw square
            elem.DrawLine(pen, new PointF(x - 4, y - 8), new PointF(x - 8, y - 8));
            elem.DrawLine(pen, new PointF(x - 8, y), new PointF(x - 12, y));
            elem.DrawLine(pen, new PointF(x - 8, y - 8), new PointF(x - 12, y));
        }

        public override void drawTree(int x, int y)
        {
            Pen pen = new Pen(Color.Black);
            Graphics elem = drawingSpace.CreateGraphics();

            //drawing the rectangle
            elem.DrawRectangle(pen, x, y, 2, 12);

            //drawng the branches
            elem.DrawLine(pen, new PointF(x + 1, y), new PointF(x + 1, y - 12));
            elem.DrawLine(pen, new PointF(x + 1, y), new PointF(x + 4, y - 12));
            elem.DrawLine(pen, new PointF(x + 1, y), new PointF(x + 6, y - 12));
            elem.DrawLine(pen, new PointF(x + 1, y), new PointF(x + 8, y - 12));
            elem.DrawLine(pen, new PointF(x + 1, y), new PointF(x - 3, y - 12));
            elem.DrawLine(pen, new PointF(x + 1, y), new PointF(x - 5, y - 12));
            elem.DrawLine(pen, new PointF(x + 1, y), new PointF(x - 7, y - 12));
        }

        public override void drawWaterSource(int x, int y)
        {
            
        }
        public override void paintTerrain()
        {
            base.drawingSpace.BackColor = System.Drawing.Color.Yellow;
        }
    }
}
