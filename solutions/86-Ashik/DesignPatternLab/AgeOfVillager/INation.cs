using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillager
{
    interface INation
    {
        //A nation has a terrain, house, tree, water resource and so on
        void drawTree(MouseEventArgs e);
        void drawHouse(MouseEventArgs e);
        void drawWaterSource(MouseEventArgs e);
    }
}
