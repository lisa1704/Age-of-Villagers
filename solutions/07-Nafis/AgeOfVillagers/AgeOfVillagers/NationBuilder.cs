using System;
using System.Collections.Generic;
using System.Text;

namespace AgeOfVillagers
{
    class NationBuilder
    {
        public INations BuildNations(string text)
        {
            if(text == "Bangladeshi Farmers")
            {
                return new BangladeshiFarmers();
            }

            else if(text == "Arab Bedouins")
            {
                return new ArabBedouins();
            }

            else if(text == "Egyptian Kings")
            {
                return new EgyptianKings();
            }

            else if(text == "Inuit Hunters")
            {
                return new InuitHunters();
            }

            else
            {
                return new NoNation();
            }
        }
    }
}
