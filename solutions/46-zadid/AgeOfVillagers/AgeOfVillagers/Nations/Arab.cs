using AgeOfVillagers.House;
using AgeOfVillagers.Nations;
using System.Diagnostics;
using System.Drawing;

namespace AgeOfVillagers
{
    public class Arab : Nation
    {
        public Arab()
        {
            this.hasTree = true;
            this.hasWaterSource = false;
        }
        public override void BackgoundColor(Graphics g)
        {
            g.Clear(Color.LightYellow);
            Debug.WriteLine("Yellowish");
        }

        public override void DrawHouse(Graphics g, Point location)
        {
            ArabianHouse arabianHouse  = new ArabianHouse();
            HouseContext houseContext = new HouseContext(arabianHouse, g, location, houseSize);

            houseContext.HouseDrawing();

            Debug.WriteLine("Drawing Arab House");
        }

        public override void DrawTree(Graphics g, Point location)
        {
            
        }

        //Dead Code//
        public override void DrawWaterResource(Graphics g, Point location)
        {
            
        }
    }
}
