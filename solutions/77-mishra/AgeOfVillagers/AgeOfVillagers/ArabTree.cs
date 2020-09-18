using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class ArabTree : IShape
    {
        
        public Panel drawingBoard;

        public ArabTree(Panel drawingBoard)
        {
            this.drawingBoard = drawingBoard;
        }


        public void draw(Point p, Panel drawingBoard)
        {
            Graphics g = drawingBoard.CreateGraphics();
            Pen pen = new Pen(Color.Green);

            g.DrawLine(pen, p.X, p.Y, p.X, p.Y - 14);
            g.DrawLine(pen, p.X, p.Y, p.X + 8, p.Y + 3);
            g.DrawLine(pen, p.X, p.Y, p.X + 5, p.Y + 6);
            g.DrawLine(pen, p.X, p.Y, p.X, p.Y + 10);
            g.DrawLine(pen, p.X, p.Y, p.X - 5, p.Y + 6);
            g.DrawLine(pen, p.X, p.Y, p.X - 8, p.Y - 3);
           
        }
    }
}
