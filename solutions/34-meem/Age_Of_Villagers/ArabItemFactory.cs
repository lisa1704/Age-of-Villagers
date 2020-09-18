using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_Of_Villagers
{
    class ArabItemFactory : ItemFactory
    {
        public override IVillageItem getItem(string button)
        {
            if (button == "House")
            {
                return new ArabBedouinHouse();
            }
            else if (button == "Tree")
            {
                return new ArabBedouinTree();
            }
           

            return null;
        }
    }
}
