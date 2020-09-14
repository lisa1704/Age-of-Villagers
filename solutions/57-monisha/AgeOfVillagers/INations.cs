using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    interface INations
    {
        string DrawHouse(Graphics g,Point pt);
        void DrawTree(Graphics g, Point pt);
        void DrawWaterSource(Graphics g, Point MPt);
        void GetTerrainColor();
    }

    internal class NationFactory
    {
        public INations GetNation(string NationType)
        {
            if (NationType == "BangladeshiFarmers")
            {
                return new BangladeshiFarmers();
            }
            else if (NationType == "ArabBedouin")
            {
                return new ArabBedouin();
            }
            else if (NationType == "EgyptianKings")
            {
                return new EgyptianKings();
            }
            else if (NationType == "InuitHunters")
            {
                return new InuitHunters();
            }
            throw new Exception();
        }
    }
}
