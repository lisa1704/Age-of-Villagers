using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    public class Village
    {
        private string villageName;
        private INation nation;
        private List<House> house_items;
        private List<WaterResource> waterResource_items;
        private List<Tree> tree_items;
        public Village(string villageName, INation nation)
        {
            this.villageName = villageName;
            this.nation = nation;
            tree_items = new List<Tree>();
            house_items = new List<House>();
            waterResource_items = new List<WaterResource>();
        }
        public void changeVillageNation(INation nation)
        {
            this.nation = nation;
        }
        public string GetVillageName()
        {
            return villageName;
        }

        public void SetVillageName(string value)
        {
            villageName = value;
        }

    }
}
