using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ageofvillagers.Nations
{
    class EgyptianKing : INation
    {
        private Graphics g;
        private Pen p;
        public EgyptianKing(Graphics g,Pen p)
        {
            this.g = g;
            this.p = p;
        }
      
        public void drawHouse(int x, int y)
        {
            Line L = new Line(g,p,x,y,50,-80);
            Line L1 = new Line(g,p,x,y,50,10);
            Line L2 = new Line(g, p, x + 50, y - 80, x+50, y+10);
            Line L3 = new Line(g,p,x+50,y-80,x+50+50,y-80+50);
            Line L4 = new Line(g,p,x+50,y+10, x + 50 + 50, y - 80 + 50);
            L.drawshape();
            L1.drawshape();
            L2.drawshape("Coordinate");
            L3.drawshape("Coordinate");
            L4.drawshape("Coordinate");
        }

        public void drawTree(int x, int y)
        {
            Line L = new Line(g, p, x, y,x+50, y-80);
            Line L1 = new Line(g, p, x, y, x - 50, y - 80);
            Line L2 = new Line(g, p, x-30, y-50, x - 30, y - 85);
            Line L3 = new Line(g, p, x - 30, y - 50, x - 60, y - 50);
            Line L4 = new Line(g, p, x + 30, y - 50,30,0);
            Line L5 = new Line(g, p, x + 30, y - 50, 0, -35);
            L.drawshape("Coordinate");
            L1.drawshape("Coordinate");
            L2.drawshape("Coordinate");
            L3.drawshape("Coordinate");
            L4.drawshape();
            L5.drawshape();

        }

        public void drawWaterSource(int x, int y)
        {
            Circle C = new Circle(g, p, x, y);
            C.drawshape();
        }


    }
}
