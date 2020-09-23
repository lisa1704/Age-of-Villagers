using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class Factory_Nation
    {
        public INation GetNation(string NationName)
        {
            if (NationName == "Bangladeshi Farmers")
            {
                return new BangladeshiFarmers();
            }
            else if (NationName == "Arab Bedouin")
            {
                return new ArabBedouin();
            }
            else if (NationName == "Egyptian Kings")
            {
                return new EgyptianKings();
            }
            else if (NationName == "Inuit Hunters")
            {
                return new InuitHunters();
            }
            else
            {
                return new NullNation();
            }
        }
    }
}