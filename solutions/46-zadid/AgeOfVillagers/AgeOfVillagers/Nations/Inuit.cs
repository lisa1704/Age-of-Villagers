using AgeOfVillagers.Data_Objects;
using AgeOfVillagers.Tree;
using AgeOfVillagers.House;
using AgeOfVillagers.WaterResource;
using AgeOfVillagers.Nations;
using System.Diagnostics;
using System.Drawing;

namespace AgeOfVillagers
{
    public class Inuit : Nation
    {
        public Inuit()
        {
            this.hasTree = false;
            this.hasWaterSource = false;
        }
        public override void BackgoundColor(Graphics g)
        {
            g.Clear(Color.White);
            Debug.WriteLine("White");
        }

        public override void DrawHouse(Graphics g, Point location)
        {
            InuitHouse inuitHouse = new InuitHouse();
            HouseContext houseContext = new HouseContext(inuitHouse, g, location, houseSize);

            houseContext.HouseDrawing();

            Debug.WriteLine("Drawing Inuit House");
        }

        //Dead Code
        public override void DrawTree(Graphics g, Point location)
        {
           
        }

        //Dead Code
        public override void DrawWaterResource(Graphics g, Point location)
        {
            
        }
    }
}
