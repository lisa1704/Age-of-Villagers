using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class EgyptianKingComponentFactory : VillageComponentFactory
    {
        public override IVillageComponent getComponent(string radiobtn)
        {
            if (radiobtn == "House")
            {
                return new EgyptianKingHouse();
            }
            else if (radiobtn == "Tree")
            {
                return new EgyptianKingTree();
            }
            else if (radiobtn == "Water source")
            {
                return new EgyptianKingRiver();
            }
            return null;
        }
    }
}
