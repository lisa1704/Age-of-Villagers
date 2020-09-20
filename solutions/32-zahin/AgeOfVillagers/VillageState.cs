using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AgeOfVillagers
{
    public class VillageState
    {
        public string villagename;
        public List<Point> house;
        public List<Point> tree;
        public List<Point> water;

        VillageState villagestate;
        public VillageState()
        {
        }
        public void setState(string villagename, List<Point> house, List<Point> tree, List<Point> water) 
        {
            this.villagestate.villagename = villagename;
            this.villagestate.house = house;
            this.villagestate.tree = tree;
            this.villagestate.water = water;
        }
        public VillageState getState() 
        {
            return villagestate;
        }
    }
}
