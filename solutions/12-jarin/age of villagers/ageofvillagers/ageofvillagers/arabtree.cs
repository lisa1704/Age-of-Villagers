using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ageofvillagers
{
    class arabtree : Shapecreate
    {
        private string Draw = "";
        public string draw(int x, int y)
        {
            Rectanglecreate rectangle  = new Rectanglecreate(x + 1, y, x + 1, y - 12, x - 1, y - 12, x - 1, y);
            Linecreate line1 = new Linecreate(x, y, x, y + 12);
            Linecreate line2 = new Linecreate (x, y, x + 8, y + 3);
            Linecreate line3 = new Linecreate(x, y, x - 8, y + 3);
            Linecreate line4 = new Linecreate(x, y, x + 5, y + 8);
            Linecreate line5 = new Linecreate(x, y, x - 5, y + 8);
            Draw = Draw + rectangle.Draws();
            Draw = Draw + line1.Draws();
            Draw = Draw + line2.Draws();
            Draw = Draw + line3.Draws();
            Draw = Draw + line4.Draws();
            Draw = Draw + line5.Draws();

            return Draw;
        }
    }
}
