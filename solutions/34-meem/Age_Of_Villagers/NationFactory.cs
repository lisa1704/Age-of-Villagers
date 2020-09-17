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
            if(nation== "Bangladeshi")
            {
                return new BangladeshiItemFactory();
            }
            return null;
        }

    }
}
