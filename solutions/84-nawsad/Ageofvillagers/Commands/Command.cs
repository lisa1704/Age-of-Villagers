using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ageofvillagers
{
    interface Command
    {
        void execute(List<State> Itemslist);

    }
}
