using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillager
{
    class NationFactory
    {
        public INation GetNation(string myNation)
        {
            if (myNation == "Bangladeshi Farmers")
            {
                return new BangladeshiFarmers();
            }
            else if (myNation == "Egyptian Kings")
            {
                return new EgyptianKings();
            }
            else if (myNation == "Arab Bedouins")
            {
                return new ArabBedouin();
            }
            else if (myNation == "Inuit Hunters")
            {
                return new InuitHunters();
            }
            throw new Exception();
        }
    }
}
