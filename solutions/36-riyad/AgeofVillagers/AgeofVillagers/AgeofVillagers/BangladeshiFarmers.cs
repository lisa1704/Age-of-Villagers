using System;
using System.Collections.Generic;
using System.Text;

namespace AgeofVillagers
{
    public class BangladeshiFarmers : INation
    {
        public string DrawHouse()
        {
            return "KureGhor";
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
