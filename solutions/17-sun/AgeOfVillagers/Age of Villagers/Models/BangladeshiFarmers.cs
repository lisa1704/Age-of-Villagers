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

        public void Draw_Tree(Point location, Graphics gfx, Pen p)
        {
            FarmerTree tree = new FarmerTree(location);
            tree.Draw(gfx, p);
        }

        public void Draw_WaterSource(Point location, Graphics gfx, Pen p)
        {
            FarmerWaterSource pond = new FarmerWaterSource(location);
            pond.Draw(gfx, p);
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
