using System;
using Age_of_Villagers.Nation_Factory_Creator;
using Age_of_Villagers.Nation;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers.Nation_Factory_Creator
{
   public class NationFactory
    {
        
        
            public INation GetNation(string nation_name)
            {
                if (nation_name == "Bangladeshi Farmers")
                {
                    return new Bangladeshi_Farmer(nation_name);
                }

                else if (nation_name == "Arab Bedouin")
                {
                return new Arab_Bedouin(nation_name);
                }

                else if (nation_name == "Egyptian King")
                {
                    return new Egyptian_King(nation_name);
                }

                else if (nation_name == "Inuit Hunter")
                {
                    return new Inuit_Hunter(nation_name);
                }

            return null;
            }
        
    }
}
