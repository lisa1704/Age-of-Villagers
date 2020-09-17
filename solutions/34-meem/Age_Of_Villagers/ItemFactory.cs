using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_Of_Villagers
{
    public abstract class ItemFactory
    {
        public abstract IVillageItem getItem(string button);
    }
}
