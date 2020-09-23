using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ageofvillagers
{
    class bangladeshihouse : Shapecreate
    {
        public string draw(int x, int y)
        {
            {
                Trianglecreate triangle = new Trianglecreate(x + 8, y, x, y + 8, x - 8, y);
                Rectanglecreate rectangle = new Rectanglecreate(x + 8, y, x + 8, y - 8, x - 8, y - 8, x - 8, y);

                triangle.Draws();
                rectangle.Draws();
               return "null";
            }
        }
    }
}
