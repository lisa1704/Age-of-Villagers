using System;
using System.Collections.Generic;
using System.Text;

namespace AgeOfVillagers
{
    public class NationNameFactory
    {
        private readonly string nationName;
        INation obj;
        public NationNameFactory(String nationName)
        {
            this.nationName = nationName;
        }
        public INation NationNameFactoryMethod()
        {
            if (nationName == "Bangladeshi Farmers")
            {
                obj = new BdFarmers();
            }
            else if (nationName == "Arab Bedouin")
            {
                obj = new ArabBedouin();
            }
            else if (nationName == "Egyptian Kings")
            {
                obj = new EgyptianKings();
            }
            else if (nationName == "Inuit Hunters")
            {
                obj = new InuitHunters();
            }
            return obj;
        }


    }

}
