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

            triangle.Draw(g, x,y,house_height/2,house_width,0);
            rectangle.Draw(g, x, y+ house_height / 2, house_height / 2, house_width ,0);

            
        }

       

        public override void DrawTree(Graphics g, int x, int y)
        {
            
            arc.Draw(g, x, y, tree_height-4, tree_width,0);
       
            rectangle.Draw(g, x+(tree_width)-10, y+ (2)*tree_height-20,12 , tree_width/4, 0);
            
            
        }

        public override void DrawWaterSource(Graphics g)
        {
            throw new NotImplementedException();
        }

        public override void SetBackground(Graphics g)
        {
            throw new NotImplementedException();
        }

        public override void SetWaterSource()
        {
            throw new NotImplementedException();
        }

        public override string getNationName()
        {
            return "Bangladeshi Farmers";
        }
    }
}
 