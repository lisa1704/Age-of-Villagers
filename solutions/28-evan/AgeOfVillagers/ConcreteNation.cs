﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    public class ConcreteNation
    {
        public INation checkNation(String nation)
        {
            if (nation == "Bangladeshi Farmers")
                return new BangladeshiFarmers();
            else if(nation == "Arab Bedouins")
                return new ArabBedouins();
            else if(nation == "Egyptian Kings")
                return new EgyptianKings();
            else if(nation == "Inuit Hunters")
                return new InuitHunters();
            else
                return new NullHandlerNation();
        }

    }
}
