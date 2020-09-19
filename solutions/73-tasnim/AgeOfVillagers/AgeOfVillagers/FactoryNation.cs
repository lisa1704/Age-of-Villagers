using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class FactoryNation
    {
        public INation NationType(string Inputnation)
        {
            if (Inputnation == "Bangladeshi Farmers")
            {
                return new BangladeshiFarmers();
            }
            else if (Inputnation == "Arab Bedouin")
            {
                return new ArabBedouin();
            }
            else if (Inputnation == "Egyptian Kings")
            {
                return new EgyptianKings();
            }
            else if (Inputnation == "Inuit Hunters")
            {
                return new InuitHunters();
            }
            else
            {
                return null;
            }
        }
    }
}
