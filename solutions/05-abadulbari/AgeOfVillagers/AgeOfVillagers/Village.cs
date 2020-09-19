using AgeOfVillagers.Nation;
using AgeOfVillagers.VillegeItems;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgeOfVillagers
{
    class Village
    {
        private INation nation;
        private string villageName;
        private List<VillageItem> trees, houses, waterSources;
        public Village(INation nation, string villageName)
        {
            this.nation = nation;
            this.villageName = villageName;
            trees = new List<VillageItem>();
            houses = new List<VillageItem>();
            waterSources = new List<VillageItem>();
        }
    }
}
