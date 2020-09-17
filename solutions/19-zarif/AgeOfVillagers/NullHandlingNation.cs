using System.Drawing;

namespace AgeOfVillagers
{
    internal class NullHandlingNation : INation
    {
        public IGraphicShape GetHouse(Point point)
        {
            return new NullHandler();
        }

        public IGraphicShape GetTrees(Point point)
        {
            return new NullHandler();
        }

        public IGraphicShape GetWaterSources(Point point)
        {
            return new NullHandler();
        }
    }
}