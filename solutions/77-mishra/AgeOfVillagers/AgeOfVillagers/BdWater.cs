using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class BdWater : IShape
    {
        private Panel drawingBoard;

        public BdWater(Panel drawingBoard)
        {
            this.drawingBoard = drawingBoard;
        }
        public void draw(Point p, Panel drawingBoard)
        {
            Graphics g = drawingBoard.CreateGraphics();
            Pen pen = new Pen(Color.Blue);

            g.DrawLine(pen, p.X, p.Y, p.X + 3, p.Y + 6);
            g.DrawLine(pen, p.X, p.Y, p.X + 5, p.Y - 5);
            g.DrawLine(pen, p.X + 3, p.Y + 6, p.X + 8, p.Y + 1);
            g.DrawLine(pen, p.X + 8, p.Y + 1, p.X + 16, p.Y + 8);
            g.DrawLine(pen, p.X + 16, p.Y + 8, p.X + 24, p.Y - 2);
            g.DrawLine(pen, p.X + 24, p.Y - 2, p.X + 15, p.Y - 8);
            g.DrawLine(pen, p.X + 15, p.Y - 8, p.X + 7, p.Y - 4);
            g.DrawLine(pen, p.X + 7, p.Y - 4, p.X + 7, p.Y - 6);
            g.DrawLine(pen, p.X + 7, p.Y - 6, p.X + 5, p.Y - 5);
            

        }
    }
}
