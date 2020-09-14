using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class InuitHunterComponentFactory : VillageComponentFactory
    {
        public override IVillageComponent getComponent(string radiobtn,Point e)
        {
            if (radiobtn == "House")
            {
                return new InuitHunterHouse(e);
            }
            return null;
        }
    }
}
