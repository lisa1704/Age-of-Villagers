using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class EgyptianKingWater : IShape
    {
        private Panel drawingBoard;
        public EgyptianKingWater(Panel drawingBoard)
        {
            this.drawingBoard = drawingBoard;
        }
        public void draw(Point p, Panel drawingBoard)
        {
            Graphics g = drawingBoard.CreateGraphics();
            Pen pen = new Pen(Color.Blue);
            g.DrawArc(pen, p.X, p.Y, 12, 12, 45, 360);
        }
    }
}
