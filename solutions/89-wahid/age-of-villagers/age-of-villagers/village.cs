using age_of_villagers.nation;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace age_of_villagers
{
    class village
    {
        public Ination nation;
        public string villageName;
        public List<Point> tree, house, watersource;
        public village(Ination nation, string villageName)
        {
            this.nation = nation;
            this.villageName = villageName;
            tree = new List<Point>();
            house = new List<Point>();
            watersource = new List<Point>();
        }
    }
}
