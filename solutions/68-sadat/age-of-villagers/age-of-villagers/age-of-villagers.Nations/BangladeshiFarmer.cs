using age_of_villagers.age_of_village.Items.House;
using age_of_villagers.age_of_village.Items.Tree;
using age_of_villagers.age_of_village.Items.WaterSource;
using age_of_villagers.age_of_villagers.utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace age_of_villagers.age_of_villagers.Nations
{
    class BangladeshiFarmer : Nation
    {
        public BangladeshiFarmer(Panel villageCanvas) : base(villageCanvas)
        {
            base.house = new BangladeshiFarmerHouse();
            base.tree = new BangladeshiFarmerTree();
            base.waterSource = new BangladeshiFarmerWaterSource();
            base.color = System.Drawing.Color.Green;
        }

       
    }
}
