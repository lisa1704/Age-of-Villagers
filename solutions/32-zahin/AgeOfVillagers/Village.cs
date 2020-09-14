using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class Village
    {
        public Nations village;
        public string villagetype;
        public  Village(string villageType)
        {
            this.villagetype = villagetype;
            if (villageType == "Bangladeshi Farmers")
                village = new BangladeshiFarmers();
            if (villageType == "Arab Bedoiun")
                village = new ArabBedouin();
            if (villageType == "Egyptian Kings")
                village = new EgyptianKing();
            if (villageType == "Inuit Hunters")
                village = new InuitHunters();
        }
        public Nations GetVillage()
        {
            return village;
        }
    }
}
