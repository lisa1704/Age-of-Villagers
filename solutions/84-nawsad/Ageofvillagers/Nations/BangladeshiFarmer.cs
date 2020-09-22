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
        public void drawHouse(int x, int y)
        {
            Bangladeshi_House House = new Bangladeshi_House();
            House.Draw(g,p,x,y);
        }
        public void drawTree(int x, int y)
        {
            Bangladeshi_Tree Tree = new Bangladeshi_Tree();
            Tree.Draw(g, p, x, y);
        }

        public void drawWaterSource(int x,int y)
        {
            Bangladeshi_Water_Source water_Source = new Bangladeshi_Water_Source();
            water_Source.Draw(g,p,x,y);
        }
    }
}
