using System.Drawing;

namespace age_of_villagers
{
    class Egyptianking : INation
    {
        private Color colorofbackground = Color.Yellow;
        public Color BgColor()
        {
            return colorofbackground;
        }

        public void drawHouse(Graphics g, Point point)
        {
            throw new System.NotImplementedException();
        }

        public void drawTree(Graphics g, Point point)
        {
            throw new System.NotImplementedException();
        }
    }
}
