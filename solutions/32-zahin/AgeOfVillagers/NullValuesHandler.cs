﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class NullValuesHandler : INation
    {
        public string DrawHouse(Graphics g, Point point)
        {
            MessageBox.Show("Can not Draw House for the chosen Nation!!");
            return "Can not Draw House for the chosen Nation!!";
        }

        public Color DrawTerrain()
        {
            MessageBox.Show("Can not Draw Terrain for the Chosen Nation!!");
            return Color.Empty;
        }

        public string DrawTree(Graphics g, Point point)
        {
            MessageBox.Show("Can not Draw Tree for the Chosen Nation!!");
            return "Can not Draw Tree for the Chosen Nation!!";
        }

        public string DrawWaterSource(Graphics g, Point point)
        {
            MessageBox.Show("Can not Draw Water for the Chosen Nation!!");
            return "Can not Draw Water for the Chosen Nation!!";
        }

    }
}