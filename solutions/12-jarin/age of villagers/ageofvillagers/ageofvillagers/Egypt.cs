using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ageofvillagers
{
    class Egypt : nationcreate
    {
        public override Shapecreate item(string items)
        {
            if (items == "house")
                return new egypthouse();
            if (items == "tree")
                return new egypttree();
            if (items == "water")
                return new egyptwater();
            else
                return null;

        }
    }
}
