using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    public interface INations
    {
        string DrawHouse(Graphics g,Point pt);
        object DrawTree(Graphics g, Point pt);
        object DrawWaterSource(Graphics g, Point MPt);
        Color GetTerrainColor();
    }

    public class NationFactory
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
            else
            {
                return new NullNation();
            }
            throw new Exception();
        }
    }
}
