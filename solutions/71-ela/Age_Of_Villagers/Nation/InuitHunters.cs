using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_Of_Villagers
{
    public class InuitHunters : Nation
    {
      
        public InuitHunters()
        {
          

        }
        public override void DrawHouse(Graphics g,Point location)
        {
            InuitHuntersHouse house = new InuitHuntersHouse(location, houseSize);
            house.Draw(g);
        }

        public override void DrawTree(Graphics g, Point location)
        {
            
        }

       
       

        public override void DrawWaterSource(Graphics g, Point location)
        {
            
        }

        public override void SetBackground(Graphics g)
        {
            g.Clear(Color.White);
        }

       
    }
}
