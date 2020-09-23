using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers
{
    public class NationController
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
            else if (NationName == "Inuit Hunters")
            {
                return new InuitHunters(point);
            }
            else
            {
                return new NullNation(point);
            }
        }

    }
}
