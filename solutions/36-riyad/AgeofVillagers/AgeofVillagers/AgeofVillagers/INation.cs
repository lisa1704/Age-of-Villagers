using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeofVillagers
{
    public interface INation
    {
        string DrawHouse(Graphics g, Point p);
        void DrawTree();
        void DrawWaterSource();
    }

    internal class FactoryPattern
    {
        public INation GetNation(string type)
        {
            if (type == "BangladeshiFarmers")
            {
                return new BangladeshiFarmers();
            }
            else if (type == "EgyptianKings")
            {
                return new EgyptianKings();
            }

            else if (type == "ArabBedouin")
            {
                return new ArabBedouin();
            }

            else if (type == "InuitHunters")
            {
                return new InuitHunters();
            }
            throw new Exception("No nation selected!");
        }
    }
}
