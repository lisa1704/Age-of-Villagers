using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class InuitHunterComponentFactory : VillageComponentFactory
    {
        public override IVillageComponent getComponent(string radiobtn)
        {
            if (radiobtn == "House")
            {
                return new InuitHunterHouse();
            }
            return null;
        }
    }
}
