using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
    class Village
    {
        public string villageName = "untitled";
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
        public void addHouse(Axis house, IPainter nation)
        {
            houses.Add(house);
            nation.drawHouse(house);
        }
        public void addTree(Axis tree, IPainter nation)
        {
            trees.Add(tree);
            nation.drawTree(tree);
        }
        public void addWSource(Axis wSource, IPainter nation)
        {
            wSources.Add(wSource);
            nation.drawWaterSource(wSource);
        }
        public void repaint(IPainter nation)
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

        internal void RefreshVillage()
        {
            houses.Clear();
            trees.Clear();
            wSources.Clear();
        }
    }
}
