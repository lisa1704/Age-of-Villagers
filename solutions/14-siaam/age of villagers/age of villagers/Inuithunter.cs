using System.Drawing;

namespace age_of_villagers
{
    public class Inuithunter : INation
    {
        private Color colorofbackground = Color.White;

        public Color BgColor()
        {
            return colorofbackground;
        }

        public void drawHouse(Graphics g,Point point)
        {
            INation nation = new Null_Nation();
            nation.drawHouse(g, point);
        }

        public void drawTree(Graphics g, Point point)
        {
            INation nation = new Null_Nation();
            nation.drawTree(g, point);
        }
    }
    }
}
