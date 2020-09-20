using System;
using System.Collections.Generic;
using System.Text;

namespace AgeOfVillagers
{
    class NationFactory
    {
        public INations GetNation(string nation)
        {
            if (nation == "Arab Bedouins")
            {
                return new ArabBedouins();
            }
            if (nation == "Bangladeshi Farmers")
            {
                return new BangladeshiFarmers();
            }
            if (nation == "Egyptian Kings")
            {
                return new EgyptianKings();
            }
            else
                return new InuitHunters();
        }
    }
}
