using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_Of_Villagers
{
    class NationPropertyFactory
    {
        public  INation getNation(string nation)
        {
            if (nation == "Bangladeshi Farmers")
            {
                return new BangladeshiNation();
            }
            
            else if (nation == "Arab Bedouins")
            {
                return new ArabBedouinNation();
            }
            else if (nation == "Egyptian King")
            {
                return new EgyptianKingNation();
            }

            else if (nation == "Inuit Hunters")
            {
                return new InuitHunterNation();
            }





            return new  NullNation();
        }
    }
}
