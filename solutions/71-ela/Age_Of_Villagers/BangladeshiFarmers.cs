using System;
using System.Collections.Generic;
using System.Drawing;

namespace Age_Of_Villagers
{
    public class BangladeshiFarmers : Nation
    {
       
        IShapes1 arc, rectangle;
       
  public BangladeshiFarmers()
        {
           
           

           
        }

        public override void DrawHouse(Graphics g, Point Location)
        {

            BangladeshiFarmersHouse house = new BangladeshiFarmersHouse(Location,houseSize);

            house.Draw(g);

            
        }

       

        public override void DrawTree(Graphics g, int x, int y)
        {
            BangladeshiFarmersTree tree = new BangladeshiFarmersTree(new Point(x, y), new Point(x+6, y + 12), new Point(x + 10, y + 24), 16, 24);
            tree.Draw(g);
            
            
        }

        public override void DrawWaterSource(Graphics g, int x, int y)
        {
          
        }

        public override Color SetBackground()
        {
            return Color.PaleGreen;
        }

      
    }
}
 