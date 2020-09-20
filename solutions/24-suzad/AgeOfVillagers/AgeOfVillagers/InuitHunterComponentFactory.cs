using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class InuitHunterComponentFactory : VillageComponentFactory
    {
        public override VillageComponent getComponent(string radiobtn,Point e)
        {
            if (radiobtn == "House")
            {
                return new InuitHunterHouse(e);
            }
            return new NullVillageComponent();
        }
    }
}
