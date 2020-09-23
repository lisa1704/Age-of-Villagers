using System;
using System.Collections.Generic;
using System.Text;


namespace Age_of_villagers.Nation
{
    class NationFactory
    {
        string nationName;


        public NationFactory(string NationType)
        {
            this.nationName = NationType;
        }
        public INation GetNation(string typeofNation)
        {
            return null;
        }
    }
}
