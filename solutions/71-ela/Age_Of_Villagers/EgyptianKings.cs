using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_Of_Villagers
{
    class EgyptianKings : Nation
    {


        IShapes triangle;

        IShapes rectangle;

        IShapes arc;
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
            int house_height = houseSize.height;
            int house_width = houseSize.width;

            triangle.Draw(g, x, y, house_height, (house_width/2), 0);
            
            triangle.Draw(g, x+ (house_width / 2), y, (house_height)- house_width / 2, house_width / 2, house_width/2);



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
    