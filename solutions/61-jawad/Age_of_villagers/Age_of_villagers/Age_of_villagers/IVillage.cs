using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Age_of_villagers
{
    interface IVillage
    {
        void ExecuteAction();
    }

    public struct VillageProperties
    {
        public string name;
        public List<Point> House_point;
        public List<Point> Tree_point;
        public List<Point> Waterresource_point;
    }
}
