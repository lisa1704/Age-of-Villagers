using System;
using System.Collections.Generic;
using System.Text;

namespace AgeOfVillagers
{
    class NationFactory:INationFactory
    {
        INation nation;

        public INation GetNation(string NationBox)
        {

            if (NationBox == "Bangladeshi Farmers")
            {
                nation = new BanglaFarmers();
            }
            else if (NationBox == "Arab Bedouin")
            {
                nation = new Arabs();
            }
            else if (NationBox == "Egyptian Kings")
            {
                nation = new Egyptians();
            }
            else 
            {
                nation = new InuitHunters();
            }
        }
    }
}
