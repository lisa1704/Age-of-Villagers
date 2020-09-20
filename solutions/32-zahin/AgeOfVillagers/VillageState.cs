using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AgeOfVillagers
{
    class VillageState
    {
        public string villagename;
        public List<Point> house;
        public List<Point> tree;
        public List<Point> water;
        public VillageState(string villagename, List<Point> house, List<Point> tree, List<Point> water)
        {
            this.villagename = villagename;
            this.house = house;
            this.tree = tree;
            this.water = water;
        }
        void setState() 
        {
        }
        string getState() 
        {
            return villagename;
        }
    }
}
