using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    interface INation
    {
        void DrawHouse(Graphics g, Point point);
        void DrawTree();
        void DrawWaterSource();
    }
    internal class Factory_Nation
    {
        public INation GetNation(string NationName)
        {
            if (NationName == "Bangladeshi Farmers")
            {
                return new BangladeshiFarmers();
            }
            throw new Exception();
        }
    }


}
