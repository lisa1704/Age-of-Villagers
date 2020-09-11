using System;
using System.Collections.Generic;
using System.Text;

namespace Age_of_Villagers.Nation
{
    class Bangladeshi : INation
    {
        string name;
        
        public Bangladeshi(string name)
        {
            this.name = name;
        }
        public String getName()
        {
            return name;
        }
    }
}
