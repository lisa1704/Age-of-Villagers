using System.Drawing;

namespace AOV
{
    public class EgyptianNation : INation
    {
        public void DrawHouse(Graphics g, Point p)
        {
            EgyptHouse pyramid=new EgyptHouse(p);
            pyramid.Draw(g);
        }

        public void DrawTree(Graphics g, Point p)
        {
            EgyptTree egyptTree = new EgyptTree(p);
            egyptTree.Draw(g);
        }

        public void DrawWaterSource(Graphics g, Point p)
        {
            EgyptWater egyptWater=new EgyptWater(p);
            egyptWater.Draw(g);
        }

        public Color GetColor()
        {
            return Color.Yellow;
        }
    }
}
