using AgeOfVillagers.Nations;
using System.Diagnostics;
using System.Drawing;

namespace AgeOfVillagers
{
    public class Arab : Nation
    {
        public override void BackgoundColor(Graphics g)
        {
            g.Clear(Color.LightYellow);
            Debug.WriteLine("Yellowish");
        }

        public override void DrawHouse(Graphics g, Point location)
        {
            
        }

        public override void DrawTree(Graphics g, Point location)
        {
            
        }

        public override void DrawWaterResource(Graphics g, Point location)
        {
            
        }
    }
}
