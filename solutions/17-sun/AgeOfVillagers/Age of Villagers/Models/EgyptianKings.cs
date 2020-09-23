using Age_of_Villagers.Models.Manifests;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.Models
{
    class EgyptianKings : INation
    {
        private string nationName = "Egyptian Kings";
        private string inhabitedVillage;

        public void Draw_House(Point location, Graphics gfx, Pen p)
        {
            KingHouse house = new KingHouse(location);
            house.Draw(gfx, p);
        }

     

        public void Draw_Tree(Point location, Graphics gfx, Pen p)
        {
            KingTree tree = new KingTree(location);
            tree.Draw(gfx, p);
        }

        public void Draw_WaterSource(Point location, Graphics gfx, Pen p)
        {
            KingWaterSource water = new KingWaterSource(location);
            water.Draw(gfx, p);
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
