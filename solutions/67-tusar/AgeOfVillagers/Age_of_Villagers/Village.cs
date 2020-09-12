using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_of_Villagers
{
    class Village
    {
        public string villageName;
        public IPainter nation;
        public List<Axes> houses = new List<Axes>();
        public List<Axes> trees = new List<Axes>();
        public List<Axes> wSources = new List<Axes>();

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
        public void addHouse(Axes house)
        {
            houses.Add(house);
            nation.drawHouse(house);
        }
        public void addTree(Axes tree)
        {
            trees.Add(tree);
            nation.drawTree(tree);
        }
        public void addWSource(Axes wSource)
        {
            wSources.Add(wSource);
            nation.drawWaterSource(wSource);
        }
        public void repaint()
        {
            foreach(Axes house in houses)
            {
                nation.drawHouse(house);
            }
            foreach (Axes tree in trees)
            {
                nation.drawTree(tree);
            }
            foreach (Axes ws in wSources)
            {
                nation.drawWaterSource(ws);
            }
        }
    }
}
