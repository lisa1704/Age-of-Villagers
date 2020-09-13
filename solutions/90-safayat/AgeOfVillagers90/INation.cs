using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers90
{
    interface INation
    {
        void DrawHouse();

        void DrawTree();

        void DrawWaterSource();

    }

    internal class NationFactory
    {
        public INation GetNation(string NationType)
        {
            if(NationType == "BangladeshiFarmers")
            {
                return new BangladeshiFarmers();
            }
            else if (NationType == "ArabBedouin")
            {
                return new ArabBedouin();
            }
            else if (NationType == "EgytianKings")
            {
                return new EgyptianKings();
            }
            else if(NationType == "InuitHUnters")
            {
                return new InuitHunters();
            }
            throw new Exception();
        }

    }
}
