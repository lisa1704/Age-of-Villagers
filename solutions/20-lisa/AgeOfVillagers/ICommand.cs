using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    interface ICommand
    {

    }

    public struct VillageItems
    {
        public string nationname;
        public string villagename;
        public Color terraincolor;
        public List<Point> tp;
        public List<Point> hp;
        public List<Point> wsp;
    }


}
