using System;
using System.Collections.Generic;
using System.Text;

namespace empty_project
{
    public interface INation
    {
        void DrawTree();
        void DrawHouse();
        void DrawWaterSource();

        internal class SelectNation
        {
            public INation GetNation(string nation)
            {
                if (nation == "BangladeshiFarmers")
                    return new BangladeshiFarmers();
                else if (nation == "ArabBedouin")
                    return new ArabBedouin();
                else if (nation == "EgyptianKings")
                    return new EgyptianKings();
                else if (nation == "InuitHunters")
                    return new InuitHunters();
                throw new Exception();
            }
        }

    }
}
