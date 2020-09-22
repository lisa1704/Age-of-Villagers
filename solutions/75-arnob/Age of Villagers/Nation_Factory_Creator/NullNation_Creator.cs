using System;
using Age_of_Villagers;
using Age_of_Villagers.Nation;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
    public class NullNation_Creator : AbstractNationFactoryCreator

    {
        public override INation CollectNation()
        {
            return null;
        }
    }
}
