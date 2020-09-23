using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ageofvillagers
{
    class arabhouse : Shapecreate
    {
        public string draw(int x, int y)
        {
           
       
            Trianglecreate triangle = new Trianglecreate(x, y, x - 8, y, x - 4, y + 12);
            Rectanglecreate rectangle = new Rectanglecreate(x, y, x + 8, y + 4, x, y + 16, x - 4, y + 12);

             triangle.Draws();
             rectangle.Draws();

            return "null";
        }
    }
}
