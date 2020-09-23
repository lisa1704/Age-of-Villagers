using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    public class Factory_Nation
    {
        public INation CreateNation(string ntype)
        {
            if (ntype == "Bangladesh")
            {
                return new BangladeshFarmers();
            }
            else if (ntype == "Arab")
            {
                return new Arab_Bedouin();
            }
            else if (ntype == "Egypt")
            {
                return new Egyptian_Kings();
            }
            else if (ntype == "Inuit")
            {
                return new Inuit_Hunters();
            }
            throw new Exception();
        }
    }
}

