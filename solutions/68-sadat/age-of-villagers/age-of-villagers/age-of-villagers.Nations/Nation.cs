using age_of_villagers.age_of_villagers.utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace age_of_villagers.age_of_villagers.Nations
{
    class Nation : Ination
    {
        private Panel villageCanvas;
        public Ihouse house;
        public Itree tree;
        public IwaterSource waterSource;
        public Color color;

        public Nation(Panel villageCanvas)
        {
            this.villageCanvas = villageCanvas;
        }

        public void colorTerrain()
        {
            villageCanvas.BackColor = color;
        }

        public void createHouse(Coordinate coordinate)
        {
            house.createHouse(coordinate, villageCanvas);
        }

        public void createTree(Coordinate coordinate)
        {
            tree.createTree(coordinate, villageCanvas);
        }

        public void createWaterSource(Coordinate coordinate)
        {
            waterSource.createWaterSource(coordinate, villageCanvas);
        }
    }
}
