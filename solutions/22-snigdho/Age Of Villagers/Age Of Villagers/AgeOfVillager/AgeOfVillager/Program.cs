using System
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
            Arab_Bedouin_House arabBedouinHouse = new Arab_Bedouin_House(point);
            arabBedouinHouse.Draw(g);
            Composite arabBedouinHouse = new Arab_Bedouin_House(point);
            return arabBedouinHouse;
        }

        public Object DrawTree(Graphics g, Point point)
        public IShape DrawTree(Point point)
        {
            Arab_Bedouin_Trees arabBedouinTree = new Arab_Bedouin_Trees(point);
            arabBedouinTree.Draw(g);
            Composite arabBedouinTree = new Arab_Bedouin_Trees(point);
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
