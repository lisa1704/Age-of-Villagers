using System.Collections.Generic;
using System.Drawing;

namespace AgeOfVillagers
{
    public class StateOfVillage
    {
        public string nameOfVillage;
        public List<Point> house;
        public List<Point> tree;
        public List<Point> water;
        public StateOfVillage state;
        public StateOfVillage(string nameOfVillage, List<Point> house, List<Point> tree, List<Point> water)
        {
            this.nameOfVillage = nameOfVillage;
            this.house = house;
            this.tree = tree;
            this.water = water;
        }
    }
}