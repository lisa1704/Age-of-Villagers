using System;
using System.Collections.Generic;
using System.Text;

namespace AgeOfVillagers
{
    public class NationFactory
    {
        public INation GetNation(string NationBox)
        {

            if (NationBox == "Bangladeshi Farmers")
            {
                return new BanglaFarmers();
            }
            else if (NationBox == "Arab Bedouin")
            {
                return new Arabs();
            }
            else if (NationBox == "Egyptian Kings")
            {
                return new EgyptianKings();
            }
            else if(NationBox == "Inuit Hunters")
            {
                return new InuitHunters();
            }
            else
            {
                return new NullNationHandler();
            }
      
        }
    }
}
