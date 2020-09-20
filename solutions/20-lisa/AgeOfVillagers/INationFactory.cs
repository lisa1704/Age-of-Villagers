using System;
using System.Collections.Generic;
using System.Text;

namespace AgeOfVillagers
{
    interface INationFactory
    {
        INation GetNation(string NationBox);
    }
}
