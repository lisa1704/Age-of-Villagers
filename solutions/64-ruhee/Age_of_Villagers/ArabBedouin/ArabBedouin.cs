using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Age_of_Villagers.Age_of_Villagers;

namespace Age_of_Villagers.ArabBedouin
{
    public class ArabBedouin : INation
    {
        public Color BackgroundColor()
        {

            return Color.GreenYellow;
        }

        public void DrawHouse(Graphics g, Point point)
        {
            ArabHouse arabBedouinHouse = new ArabHouse(point);
            arabBedouinHouse.Draw(g);
        }

        public void DrawTree(Graphics g, Point point)
        {
            ArabTrees arabBedouinTree = new ArabTrees(point);
            arabBedouinTree.Draw(g);
        }

        public void DrawWaterSource(Graphics g, Point point)
        {
            NullElements arabBedouinWaterSource = new NullElements();
            arabBedouinWaterSource.drawing();
        }


        Color INation.BackgroundColor()
        {
            throw new NotImplementedException();
        }
    }
}
