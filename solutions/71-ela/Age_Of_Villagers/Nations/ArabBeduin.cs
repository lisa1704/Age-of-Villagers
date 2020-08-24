using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_Of_Villagers
{
    public class ArabBeduin : Nation
    {

        public override void DrawHouse(Graphics g,Point location)
        {
            ArabBeduinHouse house = new ArabBeduinHouse(location,houseSize);
            house.Draw(g);


        }

        public override void DrawTree(Graphics g, Point location)
        {
            ArabBeduinTree tree = new ArabBeduinTree(location, houseSize);
            tree.Draw(g);


        }



      

        public override void SetBackground(Graphics g)
        {
            g.Clear(Color.LightYellow);
        }

       

      
    }
}
