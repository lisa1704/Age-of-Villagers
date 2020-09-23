using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoV.Nations
{
    public class NationFactory
    {
        public INation GetNation(string nationType)
        {
            if (nationType == "Bangladeshi Farmers")
            {
                return new BangladeshiFarmer();
            }
            else if (nationType == "Arab Bedouin")
            {
                return new ArabBedouin();
            }
            else if (nationType == "Egyptian Kings")
            {
                return new EgyptianKing();
            }
            else if (nationType == "Inuit Hunters")
            {
                return new InuitHunters();
            }
            else
            {
                return new NullNation();
            }
        }
    }
}
