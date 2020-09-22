using System.Drawing;
using AgeOfVillagers.Items;
namespace AgeOfVillagers
{
    public class EgyptianKing : INation
    {
        Pen pen = new Pen(Color.Black);
        public EgyptianKing()
        {

        }

        public string DrawHouse(Graphics g, Point point)
        {
            EgyptHouse house = new EgyptHouse();
            house.Draw(g,point);
            return "Egypt House";
        }

        public string DrawTree(Graphics g, Point point)
        {
            EgyptTree tree = new EgyptTree();
            tree.Draw(g, point);
            return "Egypt Tree";
        }

        public string DrawWaterSource(Graphics g, Point point)
        {
            EgyptWater water = new EgyptWater();
            water.Draw(g, point);
            return "Egypt River";
        }
        public Color DrawTerrain()
        {
            return Color.Gold;
        }
    }
}
