using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers
{
    public class VillageCondition
    {
        public string name;
        public List<Point> HousePoint, TreePoint, WaterResourcePoint;

        public VillageCondition(string name, List<Point> HousePoint, List<Point> TreePoint, List<Point> WaterResourcePoint)
        {
            this.name = name;
            this.HousePoint = HousePoint;
            this.TreePoint = TreePoint;
            this.WaterResourcePoint = WaterResourcePoint;
        }
    }
}
