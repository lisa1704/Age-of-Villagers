using System.Drawing;
using AgeOfVillagers.Items;

namespace AgeOfVillagers
{
    public class BangladeshiFarmers : INation
    {
        Pen pen = new Pen(Color.Black);
        public BangladeshiFarmers()
        {
        }

        public string DrawHouse(Graphics g, Point point)
        {
            BangladeshiHouse house = new BangladeshiHouse();
            house.Draw(g, point);
            return "Bangla House";
        }

        public string DrawTree(Graphics g, Point point)
        {
            BangladeshiTree tree = new BangladeshiTree();
            tree.Draw(g, point);
            return "Bangla Tree";
        }

        public string DrawWaterSource(Graphics g, Point point)
        {
            BangladeshiWater water = new BangladeshiWater();
            water.Draw(g, point);
            return "Bangla River";

        }
        public Color DrawTerrain()
        {
            return Color.PaleGreen;
        }
    }
}
