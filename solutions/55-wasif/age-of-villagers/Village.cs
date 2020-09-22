using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age_of_villagers
{
    class Village
    {
        public string village_name;
        public List<Point> housepoint, treepoint, waterpoint;

        public Village()
        {
            housepoint = new List<Point>();
            treepoint = new List<Point>();
            waterpoint = new List<Point>();
        }

        public string getName()
        {
            return village_name;
        }

        public void setName(String villageName)
        {
            village_name = villageName;
        }
    }
}

