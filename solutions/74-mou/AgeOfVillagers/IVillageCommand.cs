using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    interface IVillageCommand
    {
        void ExecuteCommand();
    }

    public struct ItemsOfVillage
    {
        public string SVillageName;
        public List<Point> SPointsOfTree;
        public List<Point> SPointsOfHouse;
        public List<Point> SPointsOfWatersource;

    }
}
