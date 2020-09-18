using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class ArabTree : IShape
    {
        private Panel drawingBoard;

        public ArabTree(Panel drawingBoard)
        {
            this.drawingBoard = drawingBoard;
        }
        public void draw(Point p, Panel drawingBoard)
        {
            Graphics g = drawingBoard.CreateGraphics();
            Pen p = new Pen(Color.Green);
           
        }
    }
}
