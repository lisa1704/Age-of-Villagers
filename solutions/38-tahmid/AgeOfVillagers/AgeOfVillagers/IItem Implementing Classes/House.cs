using AgeOfVillagers.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgeOfVillagers.IItem_Implementing_Classes
{
    class House : IItem
    {
        public void placeItem(Shapes shape)
        {
            shape.makeShape();
        }
    }
}
