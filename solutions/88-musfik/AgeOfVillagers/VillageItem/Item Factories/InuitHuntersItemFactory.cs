using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers.VillageItem
{
    public class InuitHuntersItemFactory
    {
        private String type;
        public InuitHuntersItemFactory(String nationItem)
        {
            type = nationItem;
        }

        internal IVillageItem ItemProducer()
        {
            if (type == "House")
                return new InuitHuntersHouse();

            else if (type == "Tree")
                return new NoTree();

            else if (type == "Water")
                return new NoWaterResource();

            return new NoTree();
        }
    }
}
