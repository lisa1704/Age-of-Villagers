using System.Drawing;

namespace AgeOfVillagers90
{
    class NullNation : INation
    {
        public Color BackGroundColor()
        {
            return Color.White;
        }

        public void DrawHouse(Graphics g, Point pt)
        {
            throw new System.NotImplementedException();
        }

        public void DrawTree(Graphics g, Point pt)
        {
            throw new System.NotImplementedException();
        }

        public void DrawWaterSource(Graphics g, Point pt)
        {
            throw new System.NotImplementedException();
        }
    }
}
