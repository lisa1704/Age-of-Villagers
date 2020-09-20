using Age_of_Villagers.Nation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Age_of_Villagers.NationFactory
{
   public abstract class AbstractNationCreator
    {
        string GetNationName
        {
            get;
            set;
        }
        public abstract INation CreateNation();

    }
}
