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
        public VillageState state;
        public VillageState(string villagename, List<Point> house, List<Point> tree, List<Point> water)
        {
            this.villagename = villagename;
            this.house = house;
            this.tree = tree;
            this.water = water;
        }
        public void setState() 
        {
            state.villagename = villagename;
            foreach (Point point in house)
            {
                state.house.Add(point);
            }
            foreach (Point point in tree)
            {
                state.tree.Add(point);
            }
            foreach (Point point in water)
            {
                state.water.Add(point);
            }
        }
        public VillageState getState() 
        {
            return new VillageState(villagename, house, tree, water);
            //return state;
        }
    }
}
