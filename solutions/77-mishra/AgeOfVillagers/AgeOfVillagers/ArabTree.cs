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
        public void draw(Point p, Panel drawingBoard)
        {
            this.drawingBoard = drawingBoard;
           
        }
    }
}
