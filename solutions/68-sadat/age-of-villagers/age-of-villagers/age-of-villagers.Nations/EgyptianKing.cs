using age_of_villagers.age_of_villagers.utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace age_of_villagers.age_of_villagers.Nations
{
    class EgyptianKing : Ination
    {
        Panel villageCanvas;
        public EgyptianKing(Panel villageCanvas)
        {
            this.villageCanvas = villageCanvas;
        }
        public void colorTerrain()
        {
            villageCanvas.BackColor = System.Drawing.Color.Yellow;
        }

        public void createHouse(Coordinate coordinate)
        {

            
        }

        public void createTree(Coordinate coordinate)
        {
           

        }

        public void createWaterSource(Coordinate coordinate)
        {
           

        }
    }
}
