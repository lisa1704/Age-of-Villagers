using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.VillegeItems
{
    class NullItem : VillageItem
    {
        private readonly Point point;

        public NullItem(Point point)
        {
            this.point = point;
        }
        public new void draw(Graphics g, Pen p)
        {

        }
    }
}
