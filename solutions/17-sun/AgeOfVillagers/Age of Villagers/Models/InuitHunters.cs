using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.Models
{
    class InuitHunters : INation
    {
        private string nationName = "Inuit Hunters";
        private string inhabitedVillage;


        public void Draw_House(Point location, Graphics gfx, Pen p)
        {
            throw new NotImplementedException();
        }

        public void Draw_Terrain()
        {
            throw new NotImplementedException();
        }

        public void Draw_Tree(Point location, Graphics gfx, Pen p)
        {
            throw new NotImplementedException();
        }

        public void Draw_WaterSource()
        {
            throw new NotImplementedException();
        }

        public string Get_inhabitedVillage()
        {
            return inhabitedVillage;
        }

        public string Get_NationName()
        {
            return nationName;
        }

        public void Set_inhabitedVillage(string village)
        {
            this.inhabitedVillage = village;
        }
    }
}
