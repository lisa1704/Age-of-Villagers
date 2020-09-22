﻿
using Age_of_Villagers;
using System.Diagnostics;
using System.Drawing;

namespace Age_of_Villagers
{
    public class Arab : Nation
    {
        public Arab()
        {
            this.hasTree = true;
            this.hasWaterSource = false;
        }
        public override void BackgoundColor(Graphics g)
        {
            g.Clear(Color.LightYellow);
            Debug.WriteLine("Yellowish");
        }

        public override void DrawHouse(Graphics g, Point location)
        {
            ArabianHouse arabianHouse = new ArabianHouse(location, houseSize);
            arabianHouse.Draw(g);

            Debug.WriteLine("Drawing Arab House");
        }

        public override void DrawTree(Graphics g, Point location)
        {
            ArabianTree arabianTree = new ArabianTree(location, treeSize);
            arabianTree.Draw(g);

            Debug.WriteLine("Drawing Arab Tree");
        }

        
        public override void DrawWaterResource(Graphics g, Point location)
        {

        }
    }
}