using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers.VillegeItems
{
    class NullItem : VillageItem
    {
        private readonly Point point;

        public NullItem(Point point)
        {
            this.point = point;
        }
    }
}
