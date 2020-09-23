using System.Drawing;

namespace age_of_villagers
{
    class Bangladeshifarmer : INation
    {
        
        Pen p = new Pen(Color.Red);
        private Color colorofbackground = Color.Green;
        public Color BgColor()
        {
            return colorofbackground;
        }

        public void drawHouse(Graphics g , Point point)
        {
            BDhouse house = new BDhouse();
            house.drawComponent(g, point);

        }

        public void drawTree(Graphics g, Point point)
        {
            BDtree tree = new BDtree();
            tree.drawComponent(g, point);
        }
    }
}
