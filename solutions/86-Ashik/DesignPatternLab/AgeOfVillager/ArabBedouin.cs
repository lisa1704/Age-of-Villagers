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
            ArabBedouinsHouse arabBedouinsHouse = new ArabBedouinsHouse(g);
            arabBedouinsHouse.draw(e);
        }

        public void drawTree(MouseEventArgs e)
        {
            ArabBedouinsTree arabBedouinsTree = new ArabBedouinsTree(g);
            arabBedouinsTree.draw(e);
        }

        public void drawWaterSource(MouseEventArgs e)
        {
            MessageBox.Show("Bedouin villages do not build their own water source");
        }
    }
}
