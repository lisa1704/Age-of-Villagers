using AgeOfVillagers.Data_Objects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.House
{
    interface IHouse
    {
        public void Draw(ElementSize sz,Graphics g,Point p);
    }
}
