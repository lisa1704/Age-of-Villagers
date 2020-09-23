using System.Drawing;

namespace AOV
{
    public class InuitNation : INation
    {
        public void DrawHouse(Graphics g, Point p)
        {
            InuitHouse igloo = new InuitHouse(p);
            igloo.Draw(g);
        }

        public void DrawTree(Graphics g, Point p)
        {
            NullShape nothing = new NullShape();
            nothing.Draw(g);
        }

        public void DrawWaterSource(Graphics g, Point p)
        {
            NullShape nothing = new NullShape();
            nothing.Draw(g);
        }

        public Color GetColor()
        {
            return Color.White;
        }
    }
}
