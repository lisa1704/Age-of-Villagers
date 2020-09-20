using Age_of_Villagers.Nation;
using System;
using System.Collections.Generic;
using System.Text;
using static Age_of_Villagers.Nation.INation;

namespace Age_of_Villagers.FactoryClasses
{
   
    class NationFactory
    {
        string name;
        public Nation.INation GetNation(string NationType)
        {
            if (NationType == "Bangladeshi Farmers")
            {
                return new BangladeshiFarmers();
            }
            else if (NationType == "Arab Bedouin")
            {
                return new ArabBeduin();
            }
            else if (NationType == "Egytian Kings")
            {
                return new EgyptianKing();
            }
            else if (NationType == "Inuit HUnters")
            {
                return new InuitHunters();
            }
            else
            {
                return new NullNation();
            }
            throw new Exception();
        }

    }
}

