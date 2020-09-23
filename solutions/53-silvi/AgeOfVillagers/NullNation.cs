using System.Drawing;

namespace AgeOfVillagers
{
    internal class NullNation : INation
    {
        public Color BackgroundColor()
        {
            throw new System.NotImplementedException();
        }

        public IShape DrawHouse(Point point)
        {
            throw new System.NotImplementedException();
        }

        public IShape DrawTree(Point point)
        {
            throw new System.NotImplementedException();
        }

        public IShape DrawWaterSource(Point point)
        {
            throw new System.NotImplementedException();
        }
    }
}