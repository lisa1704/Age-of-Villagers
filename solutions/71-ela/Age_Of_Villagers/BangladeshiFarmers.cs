using System;
using System.Drawing;

namespace Age_Of_Villagers
{
    public class BangladeshiFarmers : Nation
    {


        IShapes triangle;
        
        IShapes rectangle;

        IShapes arc;
 
       



        public BangladeshiFarmers()
        {
            this.triangle = new Triangle();
            this.rectangle = new Rectangle();
            this.arc = new Arc();

           
        }

        public override void DrawHouse(Graphics g,int x,int y)
        {
            int house_height = houseSize.height;
            int house_width = houseSize.width;

            triangle.Draw(g, x,y,house_height/2,house_width,0);
            rectangle.Draw(g, x, y+ house_height / 2, house_height / 2, house_width ,0);

            
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
            throw new NotImplementedException();
        }

        public override Color SetBackground()
        {
            return Color.PaleGreen;
        }

        public override Size SetWaterSourceSize(int width, int height)
        {
            throw new NotImplementedException();
        }
    }
}
 