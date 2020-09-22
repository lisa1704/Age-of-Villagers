using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Ageofvillagers.Nations
{
    class NullNation:INation
    {
        Graphics g;
        Pen p;
        public NullNation(Graphics g,Pen p)
        {
            this.g = g;
            this.p = p;
        }
        public void drawHouse(int x, int y)
        {
            
        }

        public void drawTree(int x, int y)
        {
            
        }

        public void drawWaterSource(int x, int y)
        {
            
        }
      
    }
}
