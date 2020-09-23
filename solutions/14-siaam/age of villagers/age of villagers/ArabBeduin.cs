using System.Drawing;

namespace age_of_villagers
{
    public class ArabBeduin : INation
    {
        private Color colorofbackground = Color.Orange;
        public Color BgColor()
        {
           return colorofbackground;
        }

        public void drawHouse(Graphics g, Point point)
        {
            Arabhouse arabhouse= new Arabhouse();
            arabhouse.drawComponent(g, point);

        }

        public void drawTree(Graphics g, Point point)
        {
            Arabtree arabtree = new Arabtree();
            arabtree.drawComponent(g, point);
        }
    }
}
