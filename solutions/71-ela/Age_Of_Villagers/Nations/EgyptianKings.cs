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



        public ItemSize waterSourceSize;





        public EgyptianKings()
        {

            this.waterSourceSize = new ItemSize(12, 12);
            hasTree = true;
            hasWaterSource = true;


        }

        public override void DrawHouse(Graphics g, Point location)
        {

            EgyptianKingsHouse house = new EgyptianKingsHouse(location, treeSize);
            house.Draw(g);





        }



        public override void DrawTree(Graphics g, Point location)
        {



            EgyptianKingsTree tree = new EgyptianKingsTree(location, treeSize);
            tree.Draw(g);





        }

        public override void DrawWaterSource(Graphics g, Point location)
        {
            EgyptianKingsWaterSource waterSource = new EgyptianKingsWaterSource(location, waterSourceSize);
            waterSource.Draw(g);


        }

        public override void SetBackground(Graphics g)
        {
            g.Clear(Color.Yellow);
        }




    }
}
