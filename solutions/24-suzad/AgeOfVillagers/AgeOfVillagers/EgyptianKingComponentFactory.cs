using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class EgyptianKingComponentFactory : VillageComponentFactory
    {
        public override VillageComponent getComponent(string radiobtn,Point e)
        {
            if (radiobtn == "House")
            {
                return new EgyptianKingHouse(e);
            }
            else if (radiobtn == "Tree")
            {
                return new EgyptianKingTree(e);
            }
            else if (radiobtn == "Water source")
            {
                return new EgyptianKingRiver(e);
            }
            return new NullVillageComponent();
        }
    }
}
