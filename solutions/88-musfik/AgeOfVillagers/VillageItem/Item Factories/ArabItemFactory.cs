using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers.VillageItem
{
    public class ArabItemFactory
    {
        private String type;
        public ArabItemFactory(String nationItem)
        {
            type = nationItem;
        }

        internal IVillageItem ItemProducer()
        {
            if (type == "House")
                return new ArabHouse();

            else if (type == "Tree")
                return new ArabTree();

            else if (type == "Water")
                return new NoWaterResource();

            return new NoTree();
        }
    }
}
