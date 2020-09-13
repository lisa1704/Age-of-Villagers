using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age_of_villagers
{
    public class Bangladeshi_Farmers : INation
    { 
        public string draw_house()
        {
            return "Bangladesh house";
        }

        public string draw_tree()
        {
            return "Bangladesh tree";
        }

        public string draw_waterSource()
        {
            return "Bangladesh watersource";
        }
    }
}
