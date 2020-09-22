﻿using System;
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

        internal IVillageItem ItemProducer(Point point)
        {
            if (type == "House")
                return new ArabHouse(point);

            else if (type == "Tree")
                return new ArabTree(point);

            else if (type == "Water")
                return new NoWaterResource(point);

            return new NoTree(point);
        }
    }
}