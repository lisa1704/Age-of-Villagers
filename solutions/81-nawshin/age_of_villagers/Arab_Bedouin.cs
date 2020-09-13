using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age_of_villagers
{
    public class Arab_Bedouin : INation
    {
        public string draw_house()
        {
            return "Arab house";
        }

        public string draw_tree()
        {
            return "Arab tree";
        }

        public string draw_waterSource()
        {
            return "Arab watersource";
        }
    }
}
