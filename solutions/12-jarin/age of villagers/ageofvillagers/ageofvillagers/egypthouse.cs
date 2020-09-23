using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ageofvillagers
{
    class egypthouse : Shapecreate
    {
        public string draw(int x, int y)
        {
            Trianglecreate triangle1 = new Trianglecreate(x, y, x - 8, y + 2, x - 2, y + 16);
            Trianglecreate triangle2 = new Trianglecreate(x, y, x + 8, y + 5, x - 2, y + 16);

            triangle1.Draws();
            triangle2.Draws();

            return "null";
        }
    }
}
