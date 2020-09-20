using System.Drawing;

namespace AgeOfVillagers
{
    internal class NullHandlingNation : INation
    {


        public NullHandlingNation(Point point)
        {

        }
        public IGraphicShape GetHouse()
        {
            return new NullHandler();
        }

        public Point GetHousePoint()
        {
            return new Point();
        }

        public Color GetTerritoryColor()
        {
            return Color.Empty; 
        }

        public Point GetTreePoint()
        {
            return new Point();
        }

        public IGraphicShape GetTrees()
        {
            return new NullHandler();
        }

        public Point GetWaterPoint()
        {
            return new Point();
        }

        public IGraphicShape GetWaterSources()
        {
            return new NullHandler();
        }
    }
}