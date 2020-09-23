using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ageofvillagers
{
    class egypttree : Shapecreate
    {
        public string draw(int x, int y)
        {
            Linecreate line1 = new Linecreate(x, y, x + 3, y + 13);
            Linecreate line2 = new Linecreate(x, y, x - 4, y + 16);
            Linecreate line3 = new Linecreate(x + 3, y + 13, x + 2, y + 24);
            Linecreate line4 = new Linecreate(x + 3, y + 13, x + 6, y + 24);
            Linecreate line5 = new Linecreate(x + 3, y + 13, x + 8, y + 23);
            Linecreate line6 = new Linecreate(x - 4, y + 16, x - 3, y + 24);
            Linecreate line7 = new Linecreate(x - 4, y + 16, x - 6, y + 22);
            Linecreate line8 = new Linecreate(x - 4, y + 16, x - 8, y + 21);

            line1.Draws();
           line2.Draws();
            line3.Draws();
            line4.Draws();
           line5.Draws();
          line6.Draws();
          line7.Draws();
          line8.Draws();

            return "null";
        }
    }
}
