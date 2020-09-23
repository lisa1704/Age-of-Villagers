using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class EgyptianItemFactory : ItemFactory
    {
        public override IVillageItem getItem(string button)
        {
            if (button == "House")
            {
                return new EgyptianKingsHouse();
            }
            else if (button == "Tree")
            {
                return new EgyptianKingsTree();
            }
            else if (button == "WaterSource")
            {
                return new EgyptianKingsWaterSource();
            }

            return null;


        }
    }
}
