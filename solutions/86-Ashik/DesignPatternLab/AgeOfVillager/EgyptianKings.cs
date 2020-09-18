using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillager
{
    class EgyptianKings : INation
    {
        private readonly Graphics g;
        public EgyptianKings(Graphics graphics)
        {
            this.g = graphics;
        }

        public void drawHouse(MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void drawTree(MouseEventArgs e)
        {
            EgyptianKingsTree egyptianKingsTree = new EgyptianKingsTree(g);
            egyptianKingsTree.draw(e);
        }
    }
}
