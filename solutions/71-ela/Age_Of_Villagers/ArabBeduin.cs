using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_Of_Villagers
{
    class ArabBeduin : INations
    {
        IShapes triangle;

        IShapes rectangle;

        public String nationName;
        public  int house_width = 50;
        public  int house_height = 50;
        private  int tree_width = 16;
        private  int tree_height = 24;
        Pen p;

        public ArabBeduin()
        {
            this.triangle = new Triangle();
            this.rectangle = new Rectangle();
            this.p = new Pen(Color.Green);

        }

        public  void DrawHouse(Graphics g, int x, int y)
        {
            triangle.Draw(g, x, y, house_height / 2, house_width / 2,0);

            rectangle.Draw(g, x+ house_height / 2, y, house_height / 2, house_width / 2, house_width/4);


        }

        public  void DrawTree(Graphics g, int x, int y)
        {

            g.DrawLine(p, x + tree_width / 16, y- tree_height /2, x - tree_width / (3/2), y - tree_height );
            g.DrawLine(p, x + tree_width / 16, y - tree_height /  2, x + tree_width / (3 / 2), y - tree_height );
            g.DrawLine(p, x + tree_width / 16, y - tree_height /  2, x - tree_width/2 , y - tree_height-8);
            g.DrawLine(p, x + tree_width / 16, y - tree_height / 2, x + tree_width / ( 2), y - tree_height - 8);
            g.DrawLine(p, x + tree_width / 16, y - tree_height / 2, x + tree_width / (3 / 2), y - tree_height );


            rectangle.Draw(g, x, y, tree_height/(2), tree_width /8 ,0);
        }

        public  void DrawWaterSource(Graphics g)
        {
            throw new NotImplementedException();
        }

        public void SetBackground(Graphics g)
        {
            throw new NotImplementedException();
        }

        public  void SetWaterSource()
        {
            throw new NotImplementedException();
        }

        public string getNationName()
        {
            return "Arab Beduin";
        }
    }
}
