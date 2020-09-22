using AgeOfVillagers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Age_of_Villagers
{
    public class NationCreator
    {
        public INation GetNation(String nationType)
        {
            if (nationType == "Bangladeshi Farmers")
                return new Bangladeshi();
            else if (nationType == "Arab Bedouin")
                return new Arab();
            else if (nationType == "Egyptian Kings")
                return new Egyptian();
            else if (nationType == "Inuit Hunters")
                return new Inuit();

            return null;
        }
    }
}
