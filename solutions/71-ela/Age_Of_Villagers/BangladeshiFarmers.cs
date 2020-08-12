using System;
using System.Collections.Generic;
using System.Drawing;

namespace Age_Of_Villagers
{
    public class BangladeshiFarmers : Nation
    {
        House house;
        IShapes1 arc, rectangle;
       
  public BangladeshiFarmers()
        {
           
           

           
        }

        public override void DrawHouse(Graphics g,int x,int y)
        {

            BangladeshiFarmersHouse house = new BangladeshiFarmersHouse(new Point (x,y),new Point(x-8,y+8),new Point(x+8,y+16));

            house.Draw(g);

            
        }

       

        public override void DrawTree(Graphics g, int x, int y)
        {
            int tree_height = treeSize.height;
            int tree_width =  treeSize.width;

            arc.Draw(g, x, y, tree_height-4, tree_width,360);
       
            rectangle.Draw(g, x+(tree_width)-10, y+ (2)*tree_height-20,12 , tree_width/4, 0);
            
            
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
 