using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillager
{
    class BangladeshiFarmers : INation
    {
        private readonly Graphics g;
        public BangladeshiFarmers(Graphics graphics)
        {
            this.g = graphics;
        }
        public void drawTree(MouseEventArgs e)
        {
            BDFarmersTree tree = new BDFarmersTree(g);
            tree.draw(e);
        }
    }
}
