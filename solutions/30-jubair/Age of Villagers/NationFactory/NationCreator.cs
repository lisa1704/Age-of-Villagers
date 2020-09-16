using Age_of_Villagers.Nation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Age_of_Villagers.NationFactory
{
   public abstract class NationCreator
    {
        string nation_name
        {
            get;
            set;
        }
        public abstract INation CreateNation();
        // Factory Method Implemented

    }
}
