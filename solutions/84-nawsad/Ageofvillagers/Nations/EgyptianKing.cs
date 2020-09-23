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
        public readonly String Name = "Egyptian King";
        public EgyptianKing(Graphics g,Pen p)
        {
            this.g = g;
            this.p = p;
        }
        public string get_nation()
        {
            return Name;
        }

        public String drawHouse(int x, int y)
        {
            Egyptian_House House = new Egyptian_House();
            House.Draw(g, p, x, y);
            return "Egyptian House Drawn";
        }

        public String drawTree(int x, int y)
        {
            Egyptian_Tree Tree = new Egyptian_Tree();
            Tree.Draw(g, p, x, y);
            return "Egyptian Tree Drawn";

        }

        public String drawWaterSource(int x, int y)
        {
            Egyptian_Water_Source water_Source = new Egyptian_Water_Source();
            water_Source.Draw(g,p,x,y);
            return "Egyptian Water Source Drawn";
        }


    }
}
