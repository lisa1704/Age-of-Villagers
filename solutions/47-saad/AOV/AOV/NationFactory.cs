using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOV
{
    class NationFactory
    {
        public INation SelectNation(string typeOfNation)
        {
            if(typeOfNation== "Arab Bedouin")
            {
                return new ArabNation();
            }
            else if (typeOfNation == "Egyptian Kings")
            {
                return new EgyptianNation();
            }
            else if (typeOfNation == "Bangladeshi Farmers")
            {
                return new BangladeshiNation();
            }
            else
            {
                return new InuitNation();
            }
        }
    }
}
