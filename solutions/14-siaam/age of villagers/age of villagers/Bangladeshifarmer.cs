using System.Drawing;

namespace age_of_villagers
{
    public class Bangladeshifarmer : INation
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

        public void drawWater(Graphics g, Point point)
        {
            BDwatersrc pond = new BDwatersrc();
            pond.drawComponent(g, point);
        }
    }
}
