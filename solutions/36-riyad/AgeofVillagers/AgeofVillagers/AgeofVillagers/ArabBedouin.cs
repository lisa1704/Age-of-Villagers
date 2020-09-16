using System;
using System.Collections.Generic;
using System.Text;

namespace AgeofVillagers
{
    public class ArabBedouin : INation
    {
        public string DrawHouse()
        {
            return "Stonehouse";
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
