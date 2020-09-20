using Age_of_Villagers.Nation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Age_of_Villagers.NationFactory
{
    public class NationFactoryApplication
    {
        public AbstractNationCreator GetNation(string nation_name)  
        {
            if(nation_name == "Bangladeshi Farmers")
            {
                return new BangladeshiNationCreator();
            }

            else if (nation_name == "Arab Bedouin")
            {
                return new ArabNationCreator();
            }

            else if (nation_name == "Egyptian Kings")
            {
                return new EgyptianNationCreator();
            }

            else if (nation_name == "Inuit Hunters")
            {
                return new InuitNationCreator();
            }

            return new NullNationCreator();
        }
    }
}
