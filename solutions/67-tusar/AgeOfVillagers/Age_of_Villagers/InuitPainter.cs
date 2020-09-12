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
            Pen pen = new Pen(Color.Black);
            Graphics elem = drawingSpace.CreateGraphics();
            
            // Create start and sweep angles on ellipse. 
            float startAngle = 0.0F;
            float sweepAngle = -180.0F;

            // Draw to screen. 
            elem.DrawArc(pen, x, y, 16, 16, startAngle, sweepAngle);
            elem.DrawArc(pen, x + 4, y + 4, 8, 8, startAngle, sweepAngle);
            elem.DrawLine(pen, new PointF(x, y + 8), new PointF(x + 16, y + 8));
        }
        public override void drawTree(int x, int y)
        {
            
        }

        public override void drawWaterSource(int x, int y)
        {
            
        }
        public override void paintTerrain()
        {
            base.drawingSpace.BackColor = System.Drawing.Color.White;
        }
    }
}
