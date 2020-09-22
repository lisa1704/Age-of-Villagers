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

}
