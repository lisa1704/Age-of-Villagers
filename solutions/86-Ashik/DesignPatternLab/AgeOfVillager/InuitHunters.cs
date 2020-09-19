using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillager
{
    class InuitHunters : INation
    {
        private readonly Graphics g;

        public InuitHunters(Graphics graphics)
        {
            this.g = graphics;
        }

        public void drawHouse(MouseEventArgs e)
        {
            InuitHuntersHouse inuitHuntersHouse = new InuitHuntersHouse(g);
            inuitHuntersHouse.draw(e);
        }

        public void drawTree(MouseEventArgs e)
        {
            MessageBox.Show("Trees can not be planted");
        }

        public void drawWaterSource(MouseEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
