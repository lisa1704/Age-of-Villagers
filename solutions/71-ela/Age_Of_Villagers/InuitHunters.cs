using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_Of_Villagers
{
    class InuitHunters : Nation
    {
        IShapes arc;
        public InuitHunters()
        {
            this.arc = new Arc();

        }
        public override void DrawHouse(Graphics g, int x, int y)
        {
            int house_height = houseSize.height;
            int house_width = houseSize.width;
            arc.Draw(g, x, y, house_height,house_width, -180);
            g.DrawLine(new Pen(Color.Black), x, y + house_height / 2, x + house_width, y + house_height / 2);
            arc.Draw(g, x+house_height/3, y+ house_height / 2- house_height / 8, house_height/4, house_width/4, -180);

        }

        public override void DrawTree(Graphics g, int x, int y)
        {
            
        }

       
       

        public override void DrawWaterSource(Graphics g, int x, int y)
        {
            throw new NotImplementedException();
        }

        public override Color SetBackground()
        {
            return Color.White;
        }

        public override Size SetWaterSourceSize(int width, int height)
        {
            throw new NotImplementedException();
        }
    }
}
