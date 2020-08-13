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


      
        public ItemSize waterSource;
        Point p;




        public EgyptianKings()
        {
          
            this.waterSource = new ItemSize(12, 12);


        }

        public override void DrawHouse(Graphics g, int x, int y)
        {
           
            EgyptianKingsHouse house = new EgyptianKingsHouse(new Point(x,y),new Point(x-6,y+10),new Point(x,y+16),new Point(x+10,y+10));
            house.Draw(g);


            


        }



        public override void DrawTree(Graphics g, int x, int y)
        {
            
           int tree_height = treeSize.height;
           int tree_width = treeSize.width;
           

            Point midLeft = new Point(x - tree_width / 3, y+tree_height/2);
            Point midRight = new Point(x + tree_width /3, y + tree_height/2);
            Point bottom = new Point(x, y+tree_height);

            EgyptianKingsTree tree = new EgyptianKingsTree(midLeft,midRight,bottom,tree_height/2,tree_width/2-tree_width/6);
            tree.Draw(g);





        }

        public override void DrawWaterSource(Graphics g,int x,int y)
        {
            Arc1 waterSource = new Arc1(x, y, waterSource.height,, waterSource.width, 0, 360);
         
        }

        public override Color SetBackground()
        {
            return Color.Yellow;
        }            

   

       
    }
}
    