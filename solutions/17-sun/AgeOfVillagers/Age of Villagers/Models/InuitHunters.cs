using Age_of_Villagers.Models.Manifests;
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
            HunterHouse house = new HunterHouse(location);
            house.Draw(gfx, p);
        }

   

        public void Draw_Tree(Point location, Graphics gfx, Pen p)
        {
            HunterTree tree = new HunterTree(location);
            tree.Draw(gfx, p);
        }

        public void Draw_WaterSource(Point location, Graphics gfx, Pen p)
        {
            HunterWaterSource water = new HunterWaterSource(location);
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
