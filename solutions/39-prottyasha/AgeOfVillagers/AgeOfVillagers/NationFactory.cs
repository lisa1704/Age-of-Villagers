using System;
using System.Collections.Generic;
using System.Text;

namespace AgeOfVillagers
{
    class NationFactory
    {
        public INations GetNations(string nation)
        {
            if (nation == "arab")
            {
                return new ArabBedouins();
            }
            if (nation == "bd")
            {
                return new BangladeshiFarmers();
            }
            if (nation == "egypt")
            {
                return new EgyptianKings();
            }
            else
                return new InuitHunters();
        }
    }
}
