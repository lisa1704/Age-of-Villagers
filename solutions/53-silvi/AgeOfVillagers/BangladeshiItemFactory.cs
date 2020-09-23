using AgeOfVillagers;
using AgeOfVillagers.BangladeshiFarmers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class BangladeshiItemFactory : ItemFactory
    {
        public override IVillageItem getItem(string button)
        {
            if (button == "House")
            {
                return BangladeshiHouse();
            }
            else if (button == "Tree")
            {
                return new BangladeshiTree();
            }
            else if (button == "WaterSource")
            {
                return new BangladeshiWaterSource();
            }

            return new NullItem();

        }
    }
}
