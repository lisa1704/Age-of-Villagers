using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age_of_villagers
{
    public class village_factory
    {
        public INations village;
        public village_factory() { }
        public INations get_nation(string village_type)
        {
            if (village_type == "Bangladeshi Farmers")
                return new Bangladeshi_Farmers();
            else if (village_type == "Arab Bedouin")
                return new Arab_Beduin();
            else if (village_type == "Egyptian Kings")
                return new Egyptian_Kings();
            else if (village_type == "Inuit Hunters")
                return new Inuit_Hunters();
            else return null;
        }
    }
}
