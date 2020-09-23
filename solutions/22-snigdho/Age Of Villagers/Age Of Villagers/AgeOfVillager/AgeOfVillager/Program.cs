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

        public Object House(Graphics g, Point point)
        public IShape House(Point point)
        {
            Arab_Bedouin_House arabBedouinHouse = new Arab_Bedouin_House(point);
            arabBedouinHouse.Draw(g);
            Composite arabBedouinHouse = new Arab_Bedouin_House(point);
            return arabBedouinHouse;
        }

        public Object Tree(Graphics g, Point point)
        public IShape Tree(Point point)
        {
            Arab_Bedouin_Trees arabBedouinTree = new Arab_Bedouin_Trees(point);
            arabBedouinTree.Draw(g);
            Composite arabBedouinTree = new Arab_Bedouin_Trees(point);
            return arabBedouinTree;
        }

        public Object WaterSource(Graphics g, Point point)
        public IShape WaterSource(Point point)
        {
            NullItems arabBedouinWaterSource = new NullItems();
            arabBedouinWaterSource.drawing();
            Composite arabBedouinWaterSource = new NullItems();
            return arabBedouinWaterSource;
        }
    }
}
