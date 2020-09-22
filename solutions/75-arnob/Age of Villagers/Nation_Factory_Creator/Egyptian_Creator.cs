﻿using System;
using Age_of_Villagers.Nation;
using Age_of_Villagers.Nation_Factory_Creator;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
   public class Egyptian_Creator : AbstractNationFactoryCreator
    {
        private String nationName = "Egyptian King";

      

        public override INation CollectNation()
        {
            return new Egyptian_King(nationName);
        }
    }
}
