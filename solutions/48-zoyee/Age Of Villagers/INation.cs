using AgeOfVillagers;
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
        void Draw_House(Graphics g, Point point);
        void Draw_Tree(Graphics g, Point point);
        void Draw_WaterSource(Graphics g, Point point);

    }

    internal class FactoryNation
    {
        //public string NationName { get; private set; }

        public INation GetNation(string NationName)
        {
            if (NationName == "Bangladeshi Farmers")
            {
                return new Bangladeshi_Farmers();
            }
            if (NationName == "Egyptian Kings")
            {
                return new Egyptian_Kings();
            }

            throw new Exception();
        }
    }
}
