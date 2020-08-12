using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_Of_Villagers
{
    public class EgyptianKings : Nation
    {


        IShapes1 triangle;

        IShapes1 rectangle;

        IShapes1 arc;
        public ItemSize waterSource;





        public EgyptianKings()
        {
            this.triangle = new Triangle();
            this.rectangle = new Rectangle();
            this.arc = new Arc();
            this.waterSource = new ItemSize(12, 12);


        }

        public override void DrawHouse(Graphics g, int x, int y)
        {
           
            EgyptianKingsHouse house = new EgyptianKingsHouse(new Point(x,y),new Point(x-6,y+10),new Point(x,y+16),new Point(x+10,y+10));
            house.Draw(g);


            


        }



        public override void DrawTree(Graphics g, int x, int y)
        {
            Pen p = new Pen(Color.Black);
            int tree_height = treeSize.height;
            int tree_width = treeSize.width;
            g.DrawLine(p, x, y, x - tree_width/2, y - tree_height/2);
            g.DrawLine(p, x - tree_width/2, y - tree_height/2, x - tree_width/2+ tree_width/4 , y - tree_height/2-tree_height/2);
            g.DrawLine(p, x - tree_width / 2, y - tree_height / 2, x - tree_width / 2 - tree_width / 2, y - tree_height / 2 - tree_height/2);
            g.DrawLine(p, x - tree_width / 2, y - tree_height / 2, x - (3/2)*tree_width ,   y - tree_height / 2 - tree_width / 4);

            g.DrawLine(p, x, y, x + tree_width/2, y - tree_height/2);
            g.DrawLine(p, x + tree_width / 2, y - tree_height / 2, x + tree_width / 2 + tree_width / 4, y - tree_height / 2 - tree_height / 2);
            g.DrawLine(p, x + tree_width / 2, y - tree_height / 2, x + tree_width / 2 - tree_width / 2, y - tree_height / 2 - tree_height / 2);
            g.DrawLine(p, x + tree_width / 2, y - tree_height / 2, x + (3 / 2) * tree_width, y - tree_height / 2 - tree_width / 4);





        }

        public override void DrawWaterSource(Graphics g,int x,int y)
        {
            arc.Draw(g, x, y, waterSource.width, waterSource.height, 360);
        }

        public override Color SetBackground()
        {
            return Color.Yellow;
        }            

   

       
    }
}
    