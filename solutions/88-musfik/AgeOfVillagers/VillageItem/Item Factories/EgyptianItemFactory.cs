using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers.VillageItem
{
    public class EgyptianItemFactory
    {
        private String type;
        public EgyptianItemFactory(String ItemType)
        {
            type = ItemType;
        }

        internal IVillageItem ItemProducer(Point point)
        {
            if (type == "House")
                return new EgyptianHouse(point);

            else if (type == "Tree")
                return new EgyptianTree(point);

            else if (type == "Water")
                return new EgyptianWaterResource(point);

            return new NoTree(point);
        }
    }
}
