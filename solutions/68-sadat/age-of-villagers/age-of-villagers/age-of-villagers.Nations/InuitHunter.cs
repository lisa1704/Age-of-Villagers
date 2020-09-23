using age_of_villagers.age_of_village.Items.House;
using age_of_villagers.age_of_villagers.utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace age_of_villagers.age_of_villagers.Nations
{
    class InuitHunter : Nation
    {
        public InuitHunter(Panel villageCanvas) : base(villageCanvas)
        {
            base.house = new InuitHunterHouse();
            base.tree = null;
            base.waterSource = null;
            base.color = System.Drawing.Color.Yellow;
        }
    }
}
