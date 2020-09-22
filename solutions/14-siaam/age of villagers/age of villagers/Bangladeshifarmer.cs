using System.Drawing;

namespace age_of_villagers
{
    class Bangladeshifarmer : INation
    {
        private Color colorofbackground = Color.Green;
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
