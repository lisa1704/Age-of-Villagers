using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ageofvillagers.Nations
{
    class InuitHunters : INation
    {   
        Graphics g;
        Pen p;
        public readonly String Name = "Inuit Hunters";
        public InuitHunters(Graphics g,Pen p)
        {
            this.g = g;
            this.p = p;
        }
        public string get_nation()
        {
            return Name;
        }
        public void drawHouse(int x, int y)
        {
            Inuit_House House = new Inuit_House();
            House.Draw(g, p, x, y);
        }

        public void drawTree(int x, int y)
        {
            
        }

        public void drawWaterSource(int x, int y)
        {
            
        }
    }
}
