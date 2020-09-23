using Age_Of_Villagers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_Of_Villagers
{
    interface INation
    { 
        object Draw_House(Graphics g, Point point);
        object Draw_Tree(Graphics g, Point point);
        object Draw_WaterSource(Graphics g, Point point);
        Color BackGroundColor();
    }

    internal class FactoryNation
    {

        public INation GetNation(string NationName)
        {
            if (NationName == "Bangladeshi Farmers")
            {
                return new Bangladeshi_Farmers();
            }
            else if (NationName == "Egyptian Kings")
            {
                return new Egyptian_Kings();
            }
            else if (NationName == "Arab Bedouin")
            {
                return new Arab_Bedouin();
            }
            else
            {
                return new Null_Nation();
            }
        }
    }
}
