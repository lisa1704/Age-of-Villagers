using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age_of_villagers
{
    public class Inuit_Hunters : INation
    {
        public string draw_house()
        {
            return "Inuit house";
        }

        public string draw_tree()
        {
            return "Inuit tree";
        }

        public string draw_waterSource()
        {
            return "Inuit watersource";
        }
    }
}
