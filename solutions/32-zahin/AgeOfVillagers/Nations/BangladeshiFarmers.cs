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

        public void DrawHouse(Graphics g, Point point)
        {
            BangladeshiHouse house = new BangladeshiHouse();
            house.Draw(g, point);
        }

        public void DrawTree(Graphics g, Point point)
        {
            BangladeshiTree tree = new BangladeshiTree();
            tree.Draw(g, point);
        }

        public void DrawWaterSource(Graphics g, Point point)
        {
            BangladeshiWater water = new BangladeshiWater();
            water.Draw(g, point);

        }
        public Color DrawTerrain()
        {
            return Color.PaleGreen;
        }
    }
}
