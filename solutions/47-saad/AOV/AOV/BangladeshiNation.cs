using System.Drawing;

namespace AOV
{
    public class BangladeshiNation : INation
    {
        public void DrawHouse(Graphics g, Point p)
        {
            
            BdHouse bdHouse=new BdHouse(p);            
            bdHouse.draw(g);
        }

        public void DrawTree(Graphics g, Point p)
        {
            BdTree bdTree = new BdTree(p);
            bdTree.draw(g);
        }

        public void DrawWaterSource(Graphics g, Point p)
        {
            BdWaterSource pond = new BdWaterSource(p);
            pond.draw(g);
        }

        public Color GetColor()
        {
            return Color.Green;
        }       
    }
}
