using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillager
{
    class ArabBedouin : INation
    {
        private readonly Graphics g;
        public ArabBedouin(Graphics graphics)
        {
            this.g = graphics;
        }

        public void drawHouse(MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void drawTree(MouseEventArgs e)
        {
            ArabBedouinsTree arabBedouinsTree = new ArabBedouinsTree(g);
            arabBedouinsTree.draw(e);
        }
    }
}
