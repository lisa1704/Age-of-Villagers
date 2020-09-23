using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class InuitItemFactory : ItemFactory
    {
        public override IVillageItem getItem(string button)
        {
            if (button == "House")
            {
                return new InuitHunterHouse();
            }
            return null;
        }
    }
}
