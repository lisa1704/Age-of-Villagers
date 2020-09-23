using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers.ItemFactory
{
    class NationFactory
    {
        public static ItemFactory getNation(string nation)
        {
            if (nation == "Bangladeshi Farmers")
            {
                return new BangladeshiItemFactory();
            }
            else if (nation == "Inuit Hunters")
            {
                return new InuitItemFactory();
            }
            else if (nation == "Egyptian Kings")
            {
                return new EgyptianItemFactory();
            }
            else if (nation == "Arab Bedouins")
            {
                return new ArabItemFactory();
            }
            else
            {
                return new NullNation();
            }
            
        }
    }
}
