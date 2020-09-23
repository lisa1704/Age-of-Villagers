using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    interface ICommand
    {
        void VCommand();
    }

    public struct VillageItems
    {
        public string v;
        public List<Point> tp;
        public List<Point> hp;
        public List<Point> wsp;
    }


}
