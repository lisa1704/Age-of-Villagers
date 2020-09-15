using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class BdFarmerComponentFactory : VillageComponentFactory
    {
        public override VillageComponent getComponent(string radiobtn, Point e)
        {
            if (radiobtn=="House")
            {
                return new BdFarmerHouse(e);
            }
            else if (radiobtn=="Tree")
            {
                return new BdFarmerTree(e);
            }
            else if(radiobtn=="Water source")
            {
                return new BdFarmerRiver(e);
            }
            return new NullVillageComponent();
        }
    }
}
