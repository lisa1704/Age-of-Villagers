using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
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

                else if (nation_name == "Egyptian Kings")
                {
                    return new Egyptian_Creator();
                }

                else if (nation_name == "Inuit Hunters")
                {
                    return new Inuit_Creator();
                }

                return null;
            }
        
    }
}
