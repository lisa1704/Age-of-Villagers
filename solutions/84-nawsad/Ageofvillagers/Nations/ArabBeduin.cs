using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Ageofvillagers.Nations
{
    class ArabBeduin : INation
    {
        private Graphics g;
        private Pen p;
        public ArabBeduin(Graphics g,Pen p)
        {
            this.g = g;
            this.p = p;
        }

        public void drawHouse(int x, int y)
        {
            Triangle T = new Triangle(g, p, x, y);
            T.drawshape();
            Line L1 = new Line(g, p, x + 100, y, 100, -20);
            L1.drawshape();
            Line L2 = new Line(g, p, (x+x + 100) / 2, y - 87, 100, -20);
            L2.drawshape();
            Line L3 = new Line(g, p, x + 100 + 100, y - 20,((x + x + 100) / 2)+100, y - 87-20) ;
            L3.drawshape("Coordinate");
        }

       

        public void drawTree(int x, int y)
        {
            Rectangle D = new Rectangle(g, p, x, y, 5, 50);
            D.drawshape();
            Line L1 = new Line(g, p, (x + x + 5) / 2, (y + y + 5) / 2, 0, -50);
            Line L2 = new Line(g, p, (x + x + 5) / 2, (y + y + 5)/2, 50, -40);
            Line L3 = new Line(g, p, (x + x + 5) / 2, (y + y + 5) / 2, 100, -30);
            Line L4 = new Line(g, p, (x + x + 5) / 2, (y + y + 5) / 2, -50, -40);
            Line L5 = new Line(g, p, (x + x + 5) / 2, (y + y + 5) / 2, -100, -30);
            L1.drawshape();
            L2.drawshape();
            L3.drawshape();
            L4.drawshape();
            L5.drawshape();

        }

        public void drawWaterSource(int x, int y)
        {
            
        }
    }
}
