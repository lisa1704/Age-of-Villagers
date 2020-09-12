using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
    class Village
    {
        public string villageName;
        public List<House> houses = new List<House>();
        public List<Tree> trees = new List<Tree>();
        public List<WaterSource> wSources = new List<WaterSource>();

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
