using AgeOfVillagers.House;
using AgeOfVillagers.Nations;
using AgeOfVillagers.Tree;
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
            ArabianHouse arabianHouse  = new ArabianHouse(location,houseSize);
            arabianHouse.Draw(g);

            Debug.WriteLine("Drawing Arab House");
        }

        public override void DrawTree(Graphics g, Point location)
        {
            ArabianTree arabianTree = new ArabianTree();
            TreeContext treeContext = new TreeContext(arabianTree, g, location, treeSize);

            treeContext.TreeDrawing();

            Debug.WriteLine("Drawing Arab Tree");
        }

        //Dead Code//
        public override void DrawWaterResource(Graphics g, Point location)
        {
            
        }
    }
}
