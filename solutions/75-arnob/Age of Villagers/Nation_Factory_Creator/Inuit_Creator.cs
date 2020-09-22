using Age_of_Villagers.Nation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
    class Inuit_Creator : AbstractNationFactoryCreator
    {
        private String nationName = "Inuit Hunters";

      

        public override INation CollectNation()
        {
            return new Inuit_Hunter(nationName);
        } 
        
    }
}
