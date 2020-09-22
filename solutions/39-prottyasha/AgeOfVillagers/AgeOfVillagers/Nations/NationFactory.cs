using System;
using System.Collections.Generic;
using System.Text;

namespace AgeOfVillagers
{
    public class NationFactory
    {
        public AbstractNation getNation(string nation)
        {
            if (nation == "Arab Bedouins")
            {
                return new Arab();
            }
            else if (nation == "Bangladeshi Farmers")
            {
                return new Bangladesh();
            }
            else if (nation == "Egyptian Kings")
            {
                return new Egypt();
            }
            else if (nation == "Inuit Hunters")
            {
                return new Inuit();
            }
            return null;
        }
    }
}
