using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ageofvillagers
{
    class Banladeshitree : Shapecreate
    {
        public string draw(int x, int y)
        {
            circlecreate circle = new circlecreate (x, y + 1, 8);
            Rectanglecreate rectangle = new Rectanglecreate(x + 1, y, x + 1, y - 12, x - 1, y - 12, x - 1, y);

         circlecreate. Draws();
        Rectanglecreate. Draws();
            return "null";
        }
    }
}
