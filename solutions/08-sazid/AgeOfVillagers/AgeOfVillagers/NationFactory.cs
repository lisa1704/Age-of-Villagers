using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    public class NationFactory
    {
        public INation GetNation(string nationType)
        {
            if(nationType == "Bangladeshi Farmers")
            {
                return new BangladeshiFarmer();
            }else if(nationType == "Arab Beduin")
            {
                return new ArabBeduin();
            }else if(nationType == "Egyptian king")
            {
                return new EgyptianKing();
            }else if(nationType == "Inuit Hunter")
            {
                return new InuinHunter();
            }
            else
            {
                return null;
            }
        }
    }
}
