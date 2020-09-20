using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class EgyptianKingTree : IShape
    {
        private Panel drawingBoard;
        public EgyptianKingTree(Panel drawingBoard)
        {
            this.drawingBoard = drawingBoard;
        }
        public void draw(Point p, Panel drawingBoard)
        {
            Graphics g = drawingBoard.CreateGraphics();
            Pen pen = new Pen(Color.GreenYellow);

            g.DrawLine(pen, p.X, p.Y, p.X + 12, p.Y - 16);
            g.DrawLine(pen, p.X, p.Y, p.X - 12, p.Y - 16);
            g.DrawLine(pen, p.X - 6, p.Y - 8, p.X  - 6, p.Y - 16);
            g.DrawLine(pen, p.X - 6, p.Y - 8, p.X - 12, p.Y - 7);
            g.DrawLine(pen, p.X + 6, p.Y - 8, p.X + 12, p.Y - 7);
            g.DrawLine(pen, p.X + 6, p.Y - 8, p.X + 6, p.Y - 16);
        }
    }
}
