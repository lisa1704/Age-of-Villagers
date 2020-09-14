using System;
using System.Collections.Generic;
using System.Text;

namespace AgeOfVillagers
{
    class Village
    {
        public string Name; 
        public List<(int, int)> houses = new List<(int, int)>();
        public List<(int, int)> trees = new List<(int, int)>();
        public List<(int, int)> water_resources = new List<(int, int)>();
        public void addHouse(int X , int Y)
        {
            houses.Add((X, Y));
        }
        public void addTree(int X, int Y)
        {
            trees.Add((X, Y));
        }
        public void addWater_Resource(int X, int Y)
        {
            water_resources.Add((X, Y));
        }
        public void paintAgain()
        { 
            
        }
    }
    
}


