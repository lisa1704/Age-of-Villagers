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
            Pen pen = new Pen(Color.Brown);
            Graphics elem = drawingSpace.CreateGraphics();
            float startAngle = 0.0F;
            float sweepAngle = -180.0F;
            elem.DrawArc(pen, x, y, 16, 16, startAngle, sweepAngle);
            elem.DrawArc(pen, x + 4, y + 4, 8, 8, startAngle, sweepAngle);
            elem.DrawLine(pen, new PointF(x, y + 8), new PointF(x + 16, y + 8));

        }

        public override void drawTree(int x, int y)
        {
            MessageBox.Show("Inuit Hunters do not have Trees");
        }

        public override void drawWaterSource(int x, int y)
        {
            MessageBox.Show("Inuit Hunters do not have Water Sources");
        }
        public override void paintTerrain()
        {
            base.drawingSpace.BackColor = System.Drawing.Color.Brown;
        }
    }
}
