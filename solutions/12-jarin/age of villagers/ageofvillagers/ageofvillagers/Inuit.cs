using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ageofvillagers
{
    class Inuit : nationcreate
    {
        public override Shapecreate item(string items)
        {
            if (items == "house")
                return new inuithouse();
            else
                return null;
        }
    }
}
