using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class VillageState
    {
        
        public string _name;
        public List<Point> _housePoints, _treePoints, _WaterScPoints;
      

        public VillageState(string name, List<Point> housePoints, List<Point> treePoints, List<Point> waterScPoints)
        {
            _name = name;
            _housePoints = housePoints;
            _treePoints = treePoints;
            _WaterScPoints = waterScPoints;
        }
    }
}

