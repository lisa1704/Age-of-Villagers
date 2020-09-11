using System;
using System.Collections.Generic;
using System.Text;

namespace Age_of_Villagers.Nation
{
    class ArabBedouin : INation
    {

        string name;

        public ArabBedouin(string name)
        {
            this.name = name;
        }
        public String getName()
        {
            return name;
        }
    }
}
