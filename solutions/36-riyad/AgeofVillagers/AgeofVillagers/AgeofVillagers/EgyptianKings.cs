using System;
using System.Collections.Generic;
using System.Text;

namespace AgeofVillagers
{
    public class EgyptianKings : INation
    {
        public string DrawHouse()
        {
            return "Piramid";
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
