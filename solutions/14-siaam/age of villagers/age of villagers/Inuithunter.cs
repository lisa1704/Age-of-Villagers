using System.Drawing;

namespace age_of_villagers
{
    class Inuithunter : INation
    {
        private Color colorofbackground = Color.White;

        public Color BgColor()
        {
            return colorofbackground;
        }

        public void drawHouse(Graphics g,Point point)
        {
            throw new System.NotImplementedException();
        }
    }
}
