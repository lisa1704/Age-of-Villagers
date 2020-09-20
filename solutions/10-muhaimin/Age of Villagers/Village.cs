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
        public IPainter nation;
        public List<Axis> houses = new List<Axis>();
        public List<Axis> trees = new List<Axis>();
        public List<Axis> wSources = new List<Axis>();

        public string getName()
        {
            return villageName;
        }
        public void setName(string name)
        {
            villageName = name;
        }
        public IPainter getNation()
        {
            return nation;
        }
        public void setNation(IPainter newNation)
        {
            nation = newNation;
        }
        public void addHouse(Axis house)
        {
            houses.Add(house);
            nation.drawHouse(house);
        }
        public void addTree(Axis tree)
        {
            trees.Add(tree);
            nation.drawTree(tree);
        }
        public void addWSource(Axis wSource)
        {
            wSources.Add(wSource);
            nation.drawWaterSource(wSource);
        }
        public void repaint()
        {
            foreach (Axis house in houses)
            {
                nation.drawHouse(house);
            }
            foreach (Axis tree in trees)
            {
                nation.drawTree(tree);
            }
            foreach (Axis ws in wSources)
            {
                nation.drawWaterSource(ws);
            }
        }
    }
}
