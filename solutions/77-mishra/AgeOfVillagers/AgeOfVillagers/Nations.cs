using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class Nations
    {
        public INation nation;
        public string nationtype;
        private Point point;

        public Nations( string nationtype)
        {
            this.nationtype = nationtype;


        }
        public INation GetNation(Point point)
        {
            
            if (nationtype == "Bangladeshi Farmers")
            {
                nation = new BdFarmer(point);

            }
            else if (nationtype == "Arab Beduins")
            {
                nation = new ArabBeduin(point);
            }
            else if (nationtype == "Egyptian King")
            {
                nation = new EgyptianKing(point);
            }
            else if (nationtype == "Inuit Hunter")
            {
                nation = new InuitHunter();
            }
            else
            {
                return new NullNation(point);
            }
            return nation;
        }
    }
}
