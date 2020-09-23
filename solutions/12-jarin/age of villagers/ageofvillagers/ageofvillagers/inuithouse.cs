using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ageofvillagers
{
    class inuithouse : Shapecreate
    {
        public string draw(int x, int y)
        {
            halfcircle h1 = new halfcircle(x, y, 10);
            halfcircle h2 = new halfcircle(x, y, 3);
            return null;
        }

    }
}
