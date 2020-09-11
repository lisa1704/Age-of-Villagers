using System;
using System.Collections.Generic;
using System.Text;

namespace Age_of_Villagers.Nation
{
    class EgyptianKings : INation
    {

        string name;

        public EgyptianKings(string name)
        {
            this.name = name;
        }
        public String getName()
        {
            return name;
        }
    }
}
