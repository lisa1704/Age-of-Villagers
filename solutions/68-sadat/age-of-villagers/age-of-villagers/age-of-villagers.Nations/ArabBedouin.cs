using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using age_of_villagers.age_of_village.Items.House;
using age_of_villagers.age_of_village.Items.Tree;
using age_of_villagers.age_of_villagers.utilities;

namespace age_of_villagers.age_of_villagrs.Nations
{
    class ArabBedouin : age_of_villagers.Nations.Nation
    {

       
        public ArabBedouin(Panel villageCanvas) : base(villageCanvas)
        {
            base.house = new ArabBedouinHouse();
            base.tree = new ArabBedouinTree();
            base.waterSource = null;
            base.color = System.Drawing.Color.LightYellow;
        }
        



    }
}
