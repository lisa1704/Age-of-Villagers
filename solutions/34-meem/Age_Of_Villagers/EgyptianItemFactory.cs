﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_Of_Villagers
{
    class EgyptianItemFactory : ItemFactory
    {
        public override IVillageItem getItem(string button)
        {
            if (button == "House")
            {
                return new EgyptianHouse();
            }
            else if (button == "Tree")
            {
                return new EgyptianTree();
            }
            else if (button == "WaterSource")
            {
                return new EgyptianWaterSource();
            }

            return new NullItem(); ;

        }
    }
}
