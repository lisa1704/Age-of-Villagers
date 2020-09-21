using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Age_of_Villagers.Age_of_Villagers;

namespace Age_of_Villagers.ArabBedouin
{
    public class ArabBedouin : INation
    {
        Graphics g;
        Pen pen = new Pen(Color.Black);
        public Color BackgroundColor()
        {

            return Color.GreenYellow;
        }

        public void DrawHouse(Graphics g, Point point)
        {
            ArabHouse arabBedouinHouse = new ArabHouse(point);
            arabBedouinHouse.Draw(g,pen);
        }

        public void DrawTree(Graphics g, Point point)
        {
            ArabTrees arabBedouinTree = new ArabTrees(point);
            arabBedouinTree.Draw(g,pen);
        }

        public void DrawWaterSource(Graphics g, Point point)
        {
            NullElements arabBedouinWaterSource = new NullElements();
            arabBedouinWaterSource.drawing();
        }


    }
}
