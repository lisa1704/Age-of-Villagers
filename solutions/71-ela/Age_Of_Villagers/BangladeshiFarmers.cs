using System;
using System.Drawing;

namespace Age_Of_Villagers
{
    public class BangladeshiFarmers : Nation
    {


        IShapes triangle;
        
        IShapes rectangle;
 
       



        public BangladeshiFarmers()
        {
            this.triangle = new Triangle();
            this.rectangle = new Rectangle();
           
        }

        public override void DrawHouse(Graphics g,int x,int y)
        {
            triangle.Draw(g, x,y,house_height/2,house_width,0);
            rectangle.Draw(g, x, y+ house_height / 2, house_height / 2, house_width ,0);

            
        }

       

        public override void DrawTree(Graphics g, int x, int y)
        {
            throw new NotImplementedException();
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
