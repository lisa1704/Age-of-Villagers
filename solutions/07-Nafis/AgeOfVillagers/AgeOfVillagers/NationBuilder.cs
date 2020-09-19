using System;
using System.Collections.Generic;
using System.Text;

namespace AgeOfVillagers
{
    class NationBuilder
    {
       public INations GetNations(string text)
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

            else
            {
                return new InuitHunters();
            }
        }
    }
}
