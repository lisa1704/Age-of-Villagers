using AgeOfVillagers.Arab_Bedouin;
using AgeOfVillagers.Bangladeshi_Farmers;
using AgeOfVillagers.Egyptian_Kings;
using AgeOfVillagers.Inuit_Hunters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
namespace AgeOfVillagers
{
    public interface INation
    {
        void DrawTree(Graphics g, Point point);
        void DrawHouse(Graphics g, Point point);
        void DrawWaterSource(Graphics g, Point point);
        Color BackgroundColor();

    }
    public class Factory_Nation
    {
        public INation GetNation(string NationName)
        {
            if (NationName == "Bangladeshi Farmers")
            {
                return new BangladeshiFarmers();
            }
            else if (NationName == "Arab Bedouin")
            {
                return new ArabBedouin();
            }
            else if (NationName == "Egyptian Kings")
            {
                return new EgyptianKings();
            }
            else if (NationName == "Inuit Hunters")
            {
                return new InuitHunters();
            }
            else
            {
                return new NullNation();
            }
        }
    }
}