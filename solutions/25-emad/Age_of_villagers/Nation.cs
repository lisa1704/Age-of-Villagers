using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_villagers
{
    public class Nation
    {
        
        
        public INations CheckVillage(string nationType)
        {
            if (nationType == "Bangladeshi Farmers")
                return new BangladeshiFarmers();

            else if (nationType == "Arab Bedouin")
                return new ArabBedouin();

            else if (nationType == "Egyptian Kings")
                return new EgyptianKings();

            else if (nationType == "Inuit Hunters")
                return new Inuit();

            else
                return new NullValuesHandler();
        }
    }
}
