using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_Of_Villagers
{
    public class NationFactory
    {




        public Nation Build(string nationName)
        {
            Nation nation = null;

            if (nationName == "Arab Bedouin")
            {
                nation = new ArabBeduin();

            }
            else if (nationName == "Bangladeshi Farmers")
            {
                nation = new BangladeshiFarmers();

            }

            else if (nationName == "Egyptian Kings")
            {
                nation = new EgyptianKings();

            }
            else if (nationName == "Inuit Hunters")
            {
                nation = new InuitHunters();

            }

            else if (nationName == "Inuit Hunters")
            {

            }

            return nation;

        }
    }
}
