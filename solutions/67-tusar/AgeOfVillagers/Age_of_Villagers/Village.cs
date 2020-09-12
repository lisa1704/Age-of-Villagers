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
        public void addHouse(Axes house, IPainter nation)
        {
            houses.Add(house);
            nation.drawHouse(house);
        }
        public void addTree(Axes tree, IPainter nation)
        {
            trees.Add(tree);
            nation.drawTree(tree);
        }
        public void addWSource(Axes wSource, IPainter nation)
        {
            wSources.Add(wSource);
            nation.drawWaterSource(wSource);
        }
        public void repaint(IPainter nation)
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
        public void RefreshVillage()
        {
            houses.Clear();
            trees.Clear();
            wSources.Clear();
        }
    }
}
