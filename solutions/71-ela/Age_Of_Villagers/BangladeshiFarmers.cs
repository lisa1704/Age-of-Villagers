using System;
using System.Drawing;

namespace Age_Of_Villagers
{
    class BangladeshiFarmers : INations
    {


        IShapes triangle;
        
        IShapes rectangle;

        public  int house_width = 16;
        public  int house_height = 16;
        private  int tree_width = 16;
        private int tree_height = 24;



        public BangladeshiFarmers()
        {
            this.triangle = new Triangle();
            this.rectangle = new Rectangle();
           
        }

        public  void DrawHouse(Graphics g,int x,int y)
        {
            triangle.Draw(g, x,y,house_height/2,house_width/2);
            rectangle.Draw(g, x, y+ house_height / 2, house_height / 2, house_width / 2);

            
        }

       

        public void DrawTree(Graphics g, int x, int y)
        {
            throw new NotImplementedException();
        }

        public  void DrawWaterSource(Graphics g)
        {
            throw new NotImplementedException();
        }

        public  void SetBackground(Graphics g)
        {
            throw new NotImplementedException();
        }

        public  void SetWaterSource()
        {
            throw new NotImplementedException();
        }
    }
}
