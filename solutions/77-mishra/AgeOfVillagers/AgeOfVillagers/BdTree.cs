using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class BdTree : IShape
    {
        private Panel drawingBoard;

        public BdTree(Panel drawingBoard)
        {
            this.drawingBoard = drawingBoard;
        }
        public void draw(Point p, Panel drawingBoard)
        {
            Graphics g = drawingBoard.CreateGraphics();
            Pen pen = new Pen(Color.Green);

            g.DrawArc(pen, p.X, p.Y, 16, 24, 90, 360);
            g.DrawLine(pen, p.X + 8, p.Y + 32, p.X + 8, p.Y + 16);

            
        }
    }
}
