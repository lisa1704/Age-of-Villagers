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





        public EgyptianKings()
        {
            this.triangle = new Triangle();
            this.rectangle = new Rectangle();
            this.arc = new Arc();


        }

        public override void DrawHouse(Graphics g, int x, int y)
        {

            triangle.Draw(g, x, y, house_height, (house_width/2), 0);
            
            triangle.Draw(g, x+ (house_width / 2), y, (house_height)- house_width / 2, house_width / 2, house_width/2);



        }



        public override void DrawTree(Graphics g, int x, int y)
        {

          




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
    