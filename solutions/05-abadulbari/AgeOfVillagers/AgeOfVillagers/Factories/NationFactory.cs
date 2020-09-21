using AgeOfVillagers.Nation;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgeOfVillagers.Factories
{
    class NationFactory
    {
        string nationName;
        public NationFactory(string nationName)
        {
            this.nationName = nationName;
        }
        public INation getNation()
        {
            if(nationName == "Bangladeshi Farmers")
            {
                return new BangladeshiFarmers();
            }
            if (nationName == "Egyptian Kings")
            {
                return new EgyptianKings();
            }
            if (nationName == "Arab Bedouin")
            {
                return new ArabBedouin();
            }
            if (nationName == "Inuit Hunters")
            {
                return new InuitHunters();
            }
            return null;
        }
    }
}
