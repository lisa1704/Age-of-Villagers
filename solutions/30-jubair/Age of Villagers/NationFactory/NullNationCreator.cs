using System;
using System.Collections.Generic;
using System.Text;
using Age_of_Villagers.Nation;

namespace Age_of_Villagers.NationFactory
{
   public class NullNationCreator : AbstractNationCreator
    
    {
        public override INation CreateNation()
        {
            return new NullNation();
        }
    }
}
