using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillager
{
    interface INation
    {
        //A nation has a terrain, house, tree, water resource and so on
        ITree drawTree(MouseEventArgs e);
        IHouse drawHouse(MouseEventArgs e);
        void drawWaterSource(MouseEventArgs e);
        Color setColor();
    }
}
