﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class EgyptianKingComponentFactory : VillageComponentFactory
    {
        public override IVillageComponent getComponent(string radiobtn,Point e)
        {
            if (radiobtn == "House")
            {
                return new EgyptianKingHouse(e);
            }
            else if (radiobtn == "Tree")
            {
                return new EgyptianKingTree(e);
            }
            else if (radiobtn == "Water source")
            {
                return new EgyptianKingRiver(e);
            }
            return null;
        }
    }
}
