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
        public Nation.INation getNationName(string NationType)
        {
            if (NationType == "Bangladeshi Farmers")
            {
                return new BangladeshiFarmers();
            }
            else if (NationType == "Arab Beduin")
            {
                return new ArabBeduin();
            }
            else if (NationType == "Egytian King")
            {
                return new EgyptianKing();
            }
            else if (NationType == "Inuit Hunters")
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
