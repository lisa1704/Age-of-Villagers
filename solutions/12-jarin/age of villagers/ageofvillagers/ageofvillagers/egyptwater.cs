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
                Trianglecreate eh_triangle1 = new Trianglecreate(x, y, x - 8, y + 2, x - 2, y + 16);
                Trianglecreate eh_triangle2 = new Trianglecreate(x, y, x + 8, y + 5, x - 2, y + 16);

                trinangle.Draws();
                draw = draw + eh_triangle2.Draw();

                return draw;
            }
        }
    }
}
