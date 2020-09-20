using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ageofvillagers
{
    class BangladeshiFarmer : INation
    {
        private Graphics g;
        private Pen p;
        public BangladeshiFarmer(Graphics g,Pen p)
        {
            this.g = g;
            this.p = p;
        }
        public void drawHouse(int x,int y)
        {
            Rectangle rec = new Rectangle(g, p, x, y);
            rec.drawshape();
            Triangle T = new Triangle(g, p, x, y);
            T.drawshape();
        }

        public void drawTree()
        {
            throw new NotImplementedException();
        }

        public void drawWaterSource()
        {
            throw new NotImplementedException();
        }
    }
}
