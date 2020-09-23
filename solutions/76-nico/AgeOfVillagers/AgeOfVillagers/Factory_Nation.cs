using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    public class Factory_Nation
    {
        public INation GetNation(string NationType)
        {
            if (NationType == "Bangladesh Farmers")
            {
                return new BangladeshFarmers();
            }
            else if (NationType == "Arab Bedouin")
            {
                return new Arab_Bedouin();
            }
            else if (NationType == "Egytian Kings")
            {
                return new Egyptian_Kings();
            }
            else if (NationType == "Inuit HUnters")
            {
                return new Inuit_Hunters();
            }
            throw new Exception();
        }
    }
}

