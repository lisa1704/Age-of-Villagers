using Age_of_Villagers.Models.Manifests;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.Models
{
    class ArabBedouins : INation
    {
        private string nationName = "Arab Bedouins";
        private string inhabitedVillage;
     
        public void Draw_House(Point location, Graphics gfx, Pen p)
        {
            BedouinHouse house = new BedouinHouse(location);
            house.Draw(gfx, p);
        }


        public void Draw_Tree(Point location, Graphics gfx, Pen p)
        {
            BedouinTree tree = new BedouinTree(location);
            tree.Draw(gfx, p);
        }

        public void Draw_WaterSource(Point location, Graphics gfx, Pen p)
        {
            BedouinWaterSource water = new BedouinWaterSource(location);
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
