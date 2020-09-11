using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class BdFarmerComponentFactory : VillageComponentFactory
    {
        public override IVillageComponent getComponent(string radiobtn)
        {
            if (radiobtn=="House")
            {
                return new BdFarmerHouse();
            }
            else if (radiobtn=="Tree")
            {
                return new BdFarmerTree();
            }
            else if(radiobtn=="Water source")
            {
                return new BdFarmerRiver();
            }
            return null;
        }
    }
}
