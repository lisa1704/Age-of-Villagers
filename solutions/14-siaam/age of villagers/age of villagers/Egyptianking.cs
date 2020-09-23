using System.Drawing;

namespace age_of_villagers
{
    public class Egyptianking : INation
    {
        private Color colorofbackground = Color.Yellow;
        public Color BgColor()
        {
            return colorofbackground;
        }

        public void drawHouse(Graphics g, Point point)
        {
            Egypthouse egypthouse = new Egypthouse();
            egypthouse.drawComponent(g,point);
        }

        public void drawTree(Graphics g, Point point)
        {
            Egypttree egyptree = new Egypttree();
            egyptree.drawComponent(g, point);
        }
    }
}
