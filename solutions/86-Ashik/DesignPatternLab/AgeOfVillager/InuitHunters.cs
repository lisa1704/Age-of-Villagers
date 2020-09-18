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
        public void drawTree(MouseEventArgs e)
        {
            
        }
    }
}
