using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace empty_project
{
    public class Village
    {
        public string village = "";
        public List<Axis> houses = new List<Axis>();
        public List<Axis> trees = new List<Axis>();
        public List<Axis> watersources = new List<Axis>();
        public string getName()
        {
            return village;
        }
        public void setName(string villageName)
        {
            village = villageName;
        }
        public void insertHouse(Axis house, INation nation)
        {
            houses.Add(house);
            nation.drawHouse(house);
        }
        public void insertTree(Axis tree, INation nation)
        {
            trees.Add(tree);
            nation.drawTree(tree);
        }
        public void insertWaterSource(Axis waterSource, INation nation)
        {
            watersources.Add(waterSource);
            nation.drawWaterSource(waterSource);
        }
        public void draw(INation nation)
        {
            foreach(Axis house in houses)
            {
                nation.drawHouse(house);
            }
            foreach (Axis tree in trees)
            {
                nation.drawTree(tree);
            }
            foreach (Axis waterSource in watersources)
            {
                nation.drawWaterSource(waterSource);
            }
        }
        public void RefreshVillage()
        {
            houses.Clear();
            trees.Clear();
            watersources.Clear();
        }
    }
}
