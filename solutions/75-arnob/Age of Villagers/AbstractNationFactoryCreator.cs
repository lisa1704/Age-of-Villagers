using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
   public abstract class AbstractNationFactoryCreator
    {
        string GetNationName
        {
            get;
            set;
        }
        public abstract INation CreateNation();
    }
}
