using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ageofvillagers
{
    class halfcircle
    {
        private int x, y, radi;
        Pen pen;
        public halfcircle(Pen pen ,int x, int y, int radi)
        {
            this.x = x;
            this.y = y;
            this.radi = radi;
        }
        public string Draw()
        {
            Arc halfcircle = new Arc(pen, x - radi, y - radi, 2 * radi, 2 * radi, 0, 180);

            halfcircle.Draw();
            return null;

        }
        
    }
}
