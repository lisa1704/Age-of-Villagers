using System.Drawing;

namespace AgeOfVillagers
{
    internal class NullNation : INation
    {
        public Color BackgroundColor()
        {
            return Color.White;
        }

        public Object DrawHouse(Graphics g, Point point)
        {
            NullItems NullHouse = new NullItems();
            NullHouse.drawing();
        }

        public Object DrawTree(Point point)
        {
            NullItems NullTree = new NullItems();
            NullTree.drawing();
        }

        public Object DrawWaterSource(Point point)
        {
            NullItems NullWaterSource = new NullItems();
            NullWaterSource.drawing();
        }

        
    }
}