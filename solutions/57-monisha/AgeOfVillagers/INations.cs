using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    interface INations
    {
        string DrawHouse();
        void DrawTree();
        void DrawWaterSource();
    }

    internal class NationFactory
    {
        public INations GetNation(string NationType)
        {
            if (NationType == "BangladeshiFarmers")
            {
                return new BangladeshiFarmers();
            }
            else if (NationType == "ArabBedouin")
            {
                return new ArabBedouin();
            }
            else if (NationType == "EgyptianKings")
            {
                return new EgyptianKings();
            }
            else if (NationType == "InuitHunters")
            {
                return new InuitHunters();
            }
            throw new Exception();
        }
    }
}
