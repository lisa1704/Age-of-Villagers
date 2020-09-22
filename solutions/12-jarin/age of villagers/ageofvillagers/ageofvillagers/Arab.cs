using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ageofvillagers
{
    class Arab : nationcreate
    {
        public override Shapecreate item(string items)
        {
            if (items == "house")
                return new  arabhouse();
            if (items == "tree")
                return new arabtree();
            else
                return null;
        }
    }
}
