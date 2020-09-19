using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class BdTree : IShape
    {

        public void draw(Point p, Panel drawingBoard)
        {
            Graphics g = drawingBoard.CreateGraphics();
            Pen pen = new Pen(Color.Green);

            
        }
    }
}
