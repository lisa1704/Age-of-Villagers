using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    interface INation
    {
        void DrawTree(Graphics g, Point point);
        void DrawHouse(Graphics g, Point point);
        void DrawWaterSource(Graphics g, Point point);
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
