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
        
        
            public AbstractNationFactoryCreator GetNation(string nation_name)
            {
                if (nation_name == "Bangladeshi Farmers")
                {
                    return new BangladeshiFarmer_Creator();
                }

                else if (nation_name == "Arab Bedouin")
                {
                    return new Arab_Creator();
                }

                else if (nation_name == "Egyptian King")
                {
                    return new Egyptian_Creator();
                }

                else if (nation_name == "Inuit Hunter")
                {
                    return new Inuit_Creator();
                }

                return null;
            }
        
    }
}
