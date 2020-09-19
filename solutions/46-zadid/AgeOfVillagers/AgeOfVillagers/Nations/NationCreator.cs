using System;
using System.Collections.Generic;
using System.Text;

namespace AgeOfVillagers
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
