using AgeOfVillagers.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.IItem_Implementing_Classes
{
    class WaterSource : IItem
    {
        Point point;
        public WaterSource(Point point)
        {
            this.point = point;
        }
       
    }
}
