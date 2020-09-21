using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
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
            InuitHouse inuitHouse = new InuitHouse(location, houseSize);
            inuitHouse.Draw(g);
            Debug.WriteLine("Drawing Inuit House");
        }

        public override void DrawTree(Graphics g, Point location)
        {

        }

        public override void DrawWaterResource(Graphics g, Point location)
        {

        }
    }
}
