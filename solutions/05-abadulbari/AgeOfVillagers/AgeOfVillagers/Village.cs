using AgeOfVillagers.Nation;
using AgeOfVillagers.VillegeItems;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class Village
    {
        public INation nation;
        public string villageName;
        public List<Point> trees, houses, waterSources;
        public Village(INation nation, string villageName)
        {
            this.nation = nation;
            this.villageName = villageName;
            trees = new List<Point>();
            houses = new List<Point>();
            waterSources = new List<Point>();
        }
    }
}
