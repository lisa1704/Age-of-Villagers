using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    interface INation
    {
        void DrawTree(Graphics graphics, Point point);
        void DrawHouse(Graphics graphics, Point point);
        void DrawWaterSource(Graphics graphics, Point point);
        void SetWaterSource();
        void SetTerrain();
    }

    internal class NationFactory
    {

        public INation GetNation(string NationBox)
        {
            if(NationBox=="Bangladeshi Farmers")
            {
                return new BanglaFarmers();
            }
            else if(NationBox=="Arab Bedouin")
            {
                return new Arabs();
            }
            else if(NationBox=="Egyptian Kings")
            {
                return new Egyptians();
            }
            else if (NationBox == "Inuit Hunters")
            {
                return new InuitHunters();
            }
            throw new Exception();
        }
    }
}
