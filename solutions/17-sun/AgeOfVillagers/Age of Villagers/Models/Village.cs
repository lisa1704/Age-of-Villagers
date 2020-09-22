using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.Models
{
    class Village
    {
        private string name;
        public List<Point> housePositions;
        public List<Point> treePositions;
        public List<Point> waterSourcePositions;
        public Village(string name)
        {
            this.name = name;
        }
        string getName()
        {
            return name;
        }
    }
}
