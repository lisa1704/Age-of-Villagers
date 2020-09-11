using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class ArabBedouinComponentFactory : VillageComponentFactory
    {
        public override IVillageComponent getComponent(string radiobtn)
        {
            if(radiobtn=="House")
            {
                return new ArabBedouinHouse();
            }
            else if(radiobtn=="Tree")
            {
                return new ArabBedouinTree();
            }
            return null;
        }
    }
}
