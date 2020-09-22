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
            throw new NotImplementedException();
        }

        public void drawTree(int x, int y)
        {
            throw new NotImplementedException();
        }

        public void drawWaterSource(int x, int y)
        {
            Circle C = new Circle(g, p, x, y);
            C.drawshape();
        }
    }
}
