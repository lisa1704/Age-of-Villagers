using System;
using System.Collections.Generic;
using System.Text;

namespace AgeOfVillagers
{
    class NationFactory
    {
        INation nation;

        public INation GetNation(string selectNation)
        {

            if (selectNation == "Bangladeshi Farmers")
            {
                nation = new BanglaFarmers();
            }
            else if (selectNation == "Arab Bedouin")
            {
                nation = new Arabs();
            }
            else if (selectNation == "Egyptian Kings")
            {
                nation = new Egyptians();
            }
            else if(selectNation == "Inuit Hunters")
            {
                nation = new InuitHunters();
            }
            else
            {
                return new NullNationHandler();
            }
      
        }
    }
}
