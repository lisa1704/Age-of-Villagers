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
        Object DrawTree(Graphics g, Point point);
        Object DrawHouse(Graphics g, Point point);
        Object DrawWaterSource(Graphics g, Point point);
        Color BackgroundColor();
    }

}
