using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    public abstract class ConcreteItems
    {
        public abstract IVillage getItem(string button);
    }
}
