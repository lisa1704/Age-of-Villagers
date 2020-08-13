using System;
using System.Collections.Generic;
using System.Drawing;

namespace Age_Of_Villagers
{
    public class BangladeshiFarmers : Nation
    {
       
  public BangladeshiFarmers()
        {
           
           

           
        }

        public override void DrawHouse(Graphics g, Point location)
        {

            BangladeshiFarmersHouse house = new BangladeshiFarmersHouse(location,houseSize);

            house.Draw(g);

            
        }

       

        public override void DrawTree(Graphics g, Point location)
        {
            BangladeshiFarmersTree tree = new BangladeshiFarmersTree(location,treeSize);
            tree.Draw(g);
            
            
        }

        public override void DrawWaterSource(Graphics g, Point location)
        {
          
        }

        public override void  SetBackground(Graphics g)
        {
            g.Clear(Color.PaleGreen);
        }

      
    }
}
 