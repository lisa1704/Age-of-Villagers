using Age_of_Villagers.Models.Manifests;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.Models
{
    class BangladeshiFarmers : INation
    {
        private string nationName = "Bangladeshi Farmers";
        private string inhabitedVillage;
        
        public void Draw_House(Point location, Graphics gfx, Pen p)
        {
            FarmerHouse house = new FarmerHouse(location);
            house.Draw(gfx, p);
        }

        public void Draw_Terrain()
        {
            throw new NotImplementedException();
        }

        public void Draw_Tree()
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
