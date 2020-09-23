using System.Drawing;

namespace AOV
{
    public class EgyptianNation : INation
    {
        public void DrawHouse(Graphics g, Point p)
        {
            EgyptHouse pyramid=new EgyptHouse(p);
            pyramid.draw(g);
        }

        public void DrawTree(Graphics g, Point p)
        {
            EgyptTree egyptTree = new EgyptTree(p);
            egyptTree.draw(g);
        }

        public void DrawWaterSource(Graphics g, Point p)
        {
            EgyptWater egyptWater=new EgyptWater(p);
            egyptWater.draw(g);
        }

        public Color GetColor()
        {
            return Color.Yellow;
        }
    }
}
