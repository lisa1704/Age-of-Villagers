using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers.VillageItem
{
    public class BangladeshiItemFactory
    {
        private String type;
        public BangladeshiItemFactory(String ItemType)
        {
            type = ItemType;
        }

        internal IVillageItem ItemProducer(Point point)
        {
            if (type == "House")
                return new BangladeshiHouse(point);

            else if (type == "Tree")
                return new BangladeshiTree(point);

            else if (type == "Water")
                return new BangladeshiWaterResource(point);

            return new NoTree(point);
        }
    }
}
