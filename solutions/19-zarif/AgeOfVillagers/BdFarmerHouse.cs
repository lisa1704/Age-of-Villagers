using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
namespace AgeOfVillagers
{
    public class BdFarmerHouse : IGraphicShape
    {
        Pen pen = new Pen(Color.Black, 3);
        public void draw(Graphics g, Point p)
        {

            g.DrawLine(pen,p, new Point((p.X+2),(p.Y+10)));
        }
    }
}
