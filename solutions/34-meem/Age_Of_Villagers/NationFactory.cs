using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_Of_Villagers
{
    class NationFactory
    {
        public static ItemFactory getNation(string nation)
        {
            if(nation== "Bangladeshi Farmers")
            {
                return new BangladeshiItemFactory();
            }
            else if (nation == "Inuit Hunters")
            {
                return new InuitItemFactory();
            }
            else if (nation == "Egyptian King")
            {
                return new EgyptianItemFactory();
            }
            else if (nation == "Arab Bedouins")
            {
                return new ArabItemFactory();
            }

            return null;
        }

    }
}
