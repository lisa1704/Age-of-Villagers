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
        IShape DrawTree(Point point);
        IShape DrawHouse(Point point);
        IShape DrawWaterSource(Point point);
        Color BackgroundColor();
    }

}
