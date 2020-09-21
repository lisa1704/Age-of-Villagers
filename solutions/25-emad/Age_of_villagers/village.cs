using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_villagers
{
    public class Village
    {
        public INations village;
        
        public INations CheckVillage(string villageType)
        {
            if (villageType == "Bangladeshi Farmers")
                return new BangladeshiFarmers();

            else if (villageType == "Arab Bedouin")
                return new ArabBedouin();

            else if (villageType == "Egyptian Kings")
                return new EgyptianKings();

            else if (villageType == "Inuit Hunters")
                return new Inuit();

            else
                return new NullValuesHandler();
        }
    }
}
