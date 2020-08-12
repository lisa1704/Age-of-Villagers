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
        IShapes1 triangle;

        IShapes1 rectangle;



       

        public ArabBeduin()
        {
            this.triangle = new Triangle();
            this.rectangle = new Rectangle();
            

        }

        public override void DrawHouse(Graphics g, int x, int y)
        {
            ArabBeduinHouse house = new ArabBeduinHouse(new Point(x, y), new Point(x - 6, y + 10), new Point(x, y + 14), new Point(x + 8, y + 10),new Point(x+8,y-2));
            house.Draw(g);


        }

        public override void DrawTree(Graphics g, int x, int y)
        {
            Pen p = new Pen(Color.Black);
             int tree_height = treeSize.height;
            int tree_width =  treeSize.width;
            g.DrawLine(p, x + tree_width / 16, y- tree_height /2, x - tree_width / 2, y - tree_height/2 - tree_height / 8);
            g.DrawLine(p, x + tree_width / 16, y - tree_height /  2, x + tree_width / ( 2), y- tree_height / 2 - tree_height /8 );
          
            g.DrawLine(p, x + tree_width / 16, y - tree_height / 2, x + tree_width / ( 2), y - tree_height );
            g.DrawLine(p, x + tree_width / 16, y - tree_height / 2, x - tree_width / (2), y - tree_height);
            g.DrawLine(p, x + tree_width / 16, y - tree_height / 2, x - tree_width / (16), y - tree_height);


            rectangle.Draw(g, x, y, tree_height/(2), tree_width /8 ,0);
        }



        public override void DrawWaterSource(Graphics g, int x, int y)
        {
           
        }

        public override Color SetBackground()
        {
            return Color.LightYellow;
        }

       

      
    }
}
