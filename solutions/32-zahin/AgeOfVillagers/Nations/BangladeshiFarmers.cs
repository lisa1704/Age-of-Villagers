﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgeOfVillagers.Shapes;
using AgeOfVillagers.Items;

namespace AgeOfVillagers
{
    public class BangladeshiFarmers : INation
    {
        Pen pen = new Pen(Color.Black);
        public BangladeshiFarmers()
        {
        }

        public string DrawHouse(Graphics g, Point point)
        {
            BangladeshiHouse house = new BangladeshiHouse();
            house.Draw(g, point);

            return "Bangladeshi House";
        }

        public string DrawTree(Graphics g, Point point)
        {
            BangladeshiTree tree = new BangladeshiTree();
            tree.Draw(g, point);

            return "Bangladeshi Tree";
        }

        public string DrawWaterSource(Graphics g, Point point)
        {
            BangladeshiWater water = new BangladeshiWater();
            water.Draw(g, point);
            return "Bangladeshi Water Resource";
        }
        public Color DrawTerrain()
        {
            return Color.PaleGreen;
        }
    }
}
