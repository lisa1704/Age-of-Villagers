using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ageofvillagers
{
    internal class Trianglecreate { 
        
    {
        private int x1, y1, x2, y2, x3, y3;
        public Trianglecreate(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
        }
        public string Draws()
        {
            Linecreate line1 = new Linecreate(x1, y1, x2, y2);
            Linecreate  line2 = new Linecreate(x2, y2, x3, y3);
            Linecreate line3 = new Linecreate(x3, y3, x1, y1);

            return line1.Draws() + line2.Draws() + line3.Draws();

        }
    }

    }

