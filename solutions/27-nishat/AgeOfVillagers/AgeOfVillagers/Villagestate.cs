using System.Collections.Generic;
using System.Drawing;

namespace AgeOfVillagers
{
    public class Villagestate : IState
    {
        public string villagename;
        public List<Point> trees, houses, watersources;

        public Villagestate(string villagename, List<Point> trees, List<Point> houses, List<Point> watersources)
        {
            this.villagename = villagename;
            this.watersources = watersources;
            this.houses = houses;
            this.trees = trees;
        }

        public string GetVillageName()
        {
            return villagename;
        }

        public void SetVillageName(string villagename)
        {
            this.villagename = villagename;
        }
    }
}
