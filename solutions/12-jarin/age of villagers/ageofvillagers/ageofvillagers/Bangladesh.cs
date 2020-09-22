using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ageofvillagers
{
    class Bangladesh : nationcreate
    {
        public override Shapecreate item(string items )
        {
            if (items == "tree")
                return new Banladeshitree();
            if (items == "house")
                return new bangladeshihouse();
            if (items == "water")
                return  new abngladeshiwater();
            else
                return null;
        }
        
    }
}
