using System;
using System.Collections.Generic;
using System.Text;

namespace AgeofVillagers
{
    public class InuitHunters : INation
    {
        public string DrawHouse()
        {
            return "Igloo";
        }

        public void DrawTree()
        {
            throw new NotImplementedException();
        }

        public void DrawWaterSource()
        {
            throw new NotImplementedException();
        }
    }
}
