using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age_of_villagers
{
    public class NationFactory
    {
        public INation CreateNation(string ntype)
        {
            if (ntype == "Bangladesh")
            {
                return new Bangladeshi_Farmers();
            }
            else if(ntype=="Arab")
            {
                return new Arab_Bedouin();
            }
            else if(ntype=="Egypt")
            {
                return new Egyptian_Kings();
            }
            else if(ntype=="Inuit")
            {
                return new Inuit_Hunters();
            }
            //throw new Exception();
            //return null;
            return new NoNation();
        }
    }
}
