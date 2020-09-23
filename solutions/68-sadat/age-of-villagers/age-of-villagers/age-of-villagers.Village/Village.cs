using System;
using System.Collections.Generic;
using System.Text;
using age_of_villagers.age_of_villagers.utilities;

namespace age_of_villagers.age_of_villagers.Village
{
    class Village
    {
        public string Name;
        public List<Coordinate> Houses = new List<Coordinate>();
        public List<Coordinate> Trees = new List<Coordinate>();
        public List<Coordinate> WaterSources = new List<Coordinate>();

        public string getName()
        {
            return Name;
        }
        public void setName(string name)
        {
            Name = name;
        }
        public void addHouse(Coordinate houseLocation)
        {
            Houses.Add(houseLocation);
        }
        public void addTree(Coordinate treeLocation)
        {
            Trees.Add(treeLocation);
        }
        public void addWaterSource(Coordinate waterSourceLocation)
        {
            WaterSources.Add(waterSourceLocation);
        }
        
    }

}
