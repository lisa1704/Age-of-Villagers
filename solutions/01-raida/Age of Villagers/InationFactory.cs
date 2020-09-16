using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
    public interface INationFactory
    {
        INation GetNation(string nation);
    }
}
