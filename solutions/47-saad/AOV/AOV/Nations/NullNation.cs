using System.Drawing;

namespace AOV
{
    class NullNation : INation
    {
        public void DrawHouse(Graphics g, Point p)
        {
            NullShape nothing = new NullShape();
            nothing.draw(g); 
        }

        public void DrawTree(Graphics g, Point p)
        {
            NullShape nothing = new NullShape();
            nothing.draw(g); 
        }

        public void DrawWaterSource(Graphics g, Point p)
        {
            NullShape nothing = new NullShape();
            nothing.draw(g); 
        }

        public Color GetColor()
        {
            return Color.WhiteSmoke;
        }
    }
}
