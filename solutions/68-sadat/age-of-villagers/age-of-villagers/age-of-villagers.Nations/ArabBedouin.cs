using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using age_of_villagers.age_of_village.Items.House;

namespace age_of_villagers.age_of_villagrs.Nations
{
    class ArabBedouin : Ination
    {
        ArabBedouinHouse arabBedouinHouse = new ArabBedouinHouse();
        private Panel villageCanvas;

        public ArabBedouin(Panel villageCanvas)
        {
            this.villageCanvas = villageCanvas;
        }

        public void colorTerrain()
        {
            throw new NotImplementedException();
        }

        public void createHouse(string item)
        {
            arabBedouinHouse.createHouse(item);
        }

        public void createTree()
        {
            throw new NotImplementedException();
        }

        public void createWaterSource()
        {
            throw new NotImplementedException();
        }
    }
}
