using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Age_of_Villagers.Age_of_Villagers;
using Age_of_Villagers.ArabBedouin;
using Age_of_Villagers.BangladeshiFarmers;
using Age_of_Villagers.EgyptianKings;
using Age_of_Villagers.InuitHunters;


namespace Age_of_Villagers.Age_of_Villagers
{
    public class NationFactory
    {
        public INation GetNation(string NationName)
        {
            if (NationName == "Bangladeshi Farmers")
            {
                return new BangladeshiFarmers.BangladeshiFarmers();
            }
            else if (NationName == "Arab Bedouin")
            {
                return new ArabBedouin.ArabBedouin();
            }
            else if (NationName == "Egyptian Kings")
            {
                return new EgyptianKings.EgyptianKings();
            }
            else if (NationName == "Inuit Hunters")
            {
                return null;
            }
            else
            {
                return new NullNation();
            }
        }
    }
}
