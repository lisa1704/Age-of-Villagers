using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ageofvillagers
{
    class egyptwater : Shapecreate
    {
        public string draw(int x, int y)
        {
            {
                Trianglecreate triangleone = new Trianglecreate(x, y, x - 8, y + 2, x - 2, y + 16);
                Trianglecreate triangletwo = new Trianglecreate(x, y, x + 8, y + 5, x - 2, y + 16);

                triangleone.Draws();
                 triangletwo.Draws();

                return "null";
            }
        }
    }
}
