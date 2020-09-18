using System.Drawing;

namespace AgeOfVillagers
{
    internal class NullHandlingNation : INation
    {
        public IGraphicShape GetHouse(Point point)
        {
            return new NullHandler();
        }

        public Color GetTerritoryColor()
        {
            return Color.Empty; 
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