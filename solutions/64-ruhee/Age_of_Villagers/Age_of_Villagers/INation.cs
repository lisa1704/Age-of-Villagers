using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Age_of_Villagers.ArabBedouin;

namespace Age_of_Villagers.Age_of_Villagers
{
    public interface INation
    {
        void DrawTree(Graphics g, Point point);
        void DrawHouse(Graphics g, Point point);
        void DrawWaterSource(Graphics g, Point point);
        Color BackgroundColor();
    }

    internal class Factory_Nation
    {
        public INation GetNation(string NationName)
        {
            if (NationName == "Bangladeshi Farmers")
            {
                return new BangladeshiFarmers.BangladeshiFarmers();
            }
            else if (NationName == "Arab Bedouin")
            {
                return new ArabBedouin.ArabBedouin();
            }
            else if (NationName == "Egyptian Kings")
            {
                return new EgyptianKings.EgyptianKings();
            }
            else if (NationName == "Inuit Hunters")
            {
                return null;
            }
            else
            {
                return new NullNation();
            }
        }
    }

}
