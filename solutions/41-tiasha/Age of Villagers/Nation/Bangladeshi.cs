﻿using Age_of_Villagers.Tree;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
    public class Bangladeshi : Nation
    {

        public Bangladeshi()
        {
            this.hasTree = true;
            this.hasWaterSource = true;
            this.waterSourceSize = new ElementSize(24, 16);
        }

        public override void BackgoundColor(Graphics g)
        {
            g.Clear(Color.PaleGreen);
            Debug.WriteLine("PaleGreen");
        }

        public override void DrawHouse(Graphics g, Point location)
        {
            BangladeshiHouse bangladeshiHouse = new BangladeshiHouse(location, houseSize);

            bangladeshiHouse.Draw(g);

            Debug.WriteLine("Drawing Bangladeshi House");
        }

        public override void DrawTree(Graphics g, Point location)
        {
            BangladeshiTree bangladeshiTree = new BangladeshiTree(location, treeSize);

            bangladeshiTree.Draw(g);

            Debug.WriteLine("Drawing Bangladeshi Tree");
        }

        public override void DrawWaterResource(Graphics g, Point location)
        {
            BangladeshiWaterSource bangladeshiWaterSource = new BangladeshiWaterSource(location, waterSourceSize);
            bangladeshiWaterSource.Draw(g);

            Debug.WriteLine("Drawing Bangladeshi Watersource");
        }
    }

}
