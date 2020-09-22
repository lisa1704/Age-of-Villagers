using System;
using Age_of_Villagers.Nation;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers.Nation_Factory_Creator
{
    public class BangladeshiFarmer_Creator : AbstractNationFactoryCreator
    {
        private String nationName = "Bangladeshi Farmers";

        

        public override INation CollectNation()
        {
            return new Bangladeshi_Farmer(nationName);
        }
           
    }
}
