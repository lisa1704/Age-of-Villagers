using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class ArabBedouinComponentFactory : VillageComponentFactory
    {
        public override IVillageComponent getComponent(string radiobtn,Point e)
        {
            if(radiobtn=="House")
            {
                return new ArabBedouinHouse(e);
            }
            else if(radiobtn=="Tree")
            {
                return new ArabBedouinTree(e);
            }
            return null;
        }
    }
}
