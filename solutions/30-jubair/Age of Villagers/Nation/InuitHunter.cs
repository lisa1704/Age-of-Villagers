using System;
using System.Collections.Generic;
using System.Text;

namespace Age_of_Villagers.Nation
{
    class InuitHunter : INation
    {
        string name;

        public InuitHunter(string name)
        {
            this.name = name;
        }
        public String getName()
        {
            return name;
        }
    }
}
