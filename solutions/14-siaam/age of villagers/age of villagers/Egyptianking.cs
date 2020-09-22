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

        public void drawHouse()
        {
            throw new System.NotImplementedException();
        }
    }
}
