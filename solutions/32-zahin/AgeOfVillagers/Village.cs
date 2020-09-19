using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    public class Village
    {
        public INation village;
        public Village() {}
        public INation GetVillage(string villageType)
        {
            if (villageType == "Bangladeshi Farmers")
                return new BangladeshiFarmers();
            else if (villageType == "Arab Bedouin")
                return new ArabBedouin();
            else if (villageType == "Egyptian Kings")
                return new EgyptianKing();
            else if (villageType == "Inuit Hunters")
                return new InuitHunters();
            else
                return new NullValuesHandler();
        }
    }
}
/*
Arab Bedouin
Bangladeshi Farmers
Egyptian Kings
Inuit Hunters*/