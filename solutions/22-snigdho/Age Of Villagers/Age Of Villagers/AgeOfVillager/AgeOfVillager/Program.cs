using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
namespace AgeOfVillagers.Arab_Bedouin
{
    public class ArabBedouin : INation
    {
        public Color BackgroundColor()
        {
            return Color.GreenYellow;
        }

        public Object DrawHouse(Graphics g, Point point)
        public IShape DrawHouse(Point point)
        {
            ArabBedouinHouse arabBedouinHouse = new ArabBedouinHouse(point);
            arabBedouinHouse.Draw(g);
            Composite arabBedouinHouse = new ArabBedouinHouse(point);
            
            return arabBedouinHouse;
        }

        public Object DrawTree(Graphics g, Point point)
        public IShape DrawTree(Point point)
        {
            ArabBedouinTrees arabBedouinTree = new ArabBedouinTrees(point);
            arabBedouinTree.Draw(g);
            Composite arabBedouinTree = new ArabBedouinTrees(point);
         
            return arabBedouinTree;
        }

        public Object DrawWaterSource(Graphics g, Point point)
        public IShape DrawWaterSource(Point point)
        {
            NullItems arabBedouinWaterSource = new NullItems();
            arabBedouinWaterSource.drawing();
            Composite arabBedouinWaterSource = new NullItems();
      
            return arabBedouinWaterSource;
        }
    }
}
