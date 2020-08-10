using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_Of_Villagers
{
    class ArabBeduin : Nation
    {
        IShapes triangle;

        IShapes rectangle;



        Pen p;

        public ArabBeduin()
        {
            this.triangle = new Triangle();
            this.rectangle = new Rectangle();
            this.p = new Pen(Color.Green);

        }

        public override void DrawHouse(Graphics g, int x, int y)
        {
            triangle.Draw(g, x, y, house_height / 2, house_width / 2,0);
            

            rectangle.Draw(g, x+ house_height / 2, y, house_height / 2, house_width / 2, house_width/4);


        }

        public override void DrawTree(Graphics g, int x, int y)
        {

            g.DrawLine(p, x + tree_width / 16, y- tree_height /2, x - tree_width / (3/2), y - tree_height );
            g.DrawLine(p, x + tree_width / 16, y - tree_height /  2, x + tree_width / (3 / 2), y - tree_height );
            g.DrawLine(p, x + tree_width / 16, y - tree_height /  2, x - tree_width/2 , y - tree_height-8);
            g.DrawLine(p, x + tree_width / 16, y - tree_height / 2, x + tree_width / ( 2), y - tree_height - 8);
            g.DrawLine(p, x + tree_width / 16, y - tree_height / 2, x + tree_width / (3 / 2), y - tree_height );


            rectangle.Draw(g, x, y, tree_height/(2), tree_width /8 ,0);
        }

        public override void DrawWaterSource(Graphics g)
        {
            
        }

        public override Color SetBackground()
        {
            return Color.Orange;
        }

        public override Size  SetWaterSourceSize(int width,int height)
        {
            return new Size();
        }

      
    }
}
