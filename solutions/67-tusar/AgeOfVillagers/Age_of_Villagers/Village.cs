using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
    class Village
    {
        protected string villageName;
        protected List<House> houses = new List<House>();
        protected List<Tree> trees = new List<Tree>();
        protected List<WaterSource> wSources = new List<WaterSource>();

        public string getName()
        {
            return villageName;
        }
        public void setName(string name)
        {
            villageName = name;
        }
        public void addHouse(House house)
        {
            houses.Add(house);
        }
        public void addTree(Tree tree)
        {
            trees.Add(tree);
        }
        public void addWSource(WaterSource wSource)
        {
            wSources.Add(wSource);
        }
    }
}
