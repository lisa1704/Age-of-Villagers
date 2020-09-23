using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ageofvillagers
{
    public class circlecreate

    {

        public class Circlecreate 
        {
            private int x, y, radi;
            public Circlecreate(int x, int y, int radi)
            {
                this.x = x;
                this.y = y;
                this.radi = radi;
            }
            public string Draws()
            {
                return "circle ";
            }
        }
    }
}
