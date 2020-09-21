using Age_of_Villagers.Nation;
using System.Drawing;

namespace Age_of_Villagers.FactoryClasses
{
    internal class NullNation : INation
    {
        public Color BackGroundColor()
        {
            return Color.White;
        }

        public Color BgColor()
        {
            throw new System.NotImplementedException();
        }

        public void DrawHouse()
        {
            throw new System.NotImplementedException();
        }

        public void DrawTree()
        {
            throw new System.NotImplementedException();
        }

        public void DrawWaterSource()
        {
            throw new System.NotImplementedException();
        }

        public VillageComponents.VillageComponents getHouse(Point p)
        {
            throw new System.NotImplementedException();
        }

        public string getNationName()
        {
            throw new System.NotImplementedException();
        }

        public VillageComponents.VillageComponents getTree(Point p)
        {
            throw new System.NotImplementedException();
        }

        public VillageComponents.VillageComponents getWaterSource(Point p)
        {
            throw new System.NotImplementedException();
        }
    }
}