using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers
{
    class NationController
    {
        private string NationName;
        private readonly Point point;
        
        public NationController(string NationName)
        {
            this.NationName = NationName;
        }

        public INation GetNation(Point point)
        {
            if (NationName =="Bangladeshi Farmers")
            {
                return new BangladeshiFarmers(point);
            }
            else if(NationName=="Arab Bedouin")
            {
                return new ArabBedouin(point);
            }
            else if (NationName == "Egyptian Kings")
            {
                return new EgyptianKing(point);
            }
            else
            {
                return new InuitHunters(point);
            }
        }

    }
}
