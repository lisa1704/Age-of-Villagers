using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_of_villagers
{
    class EgyptianKings : INations
    {

        Color bg_color = Color.Yellow;



        public void DrawHouse(Graphics graphics, Point point)
        {
            throw new NotImplementedException();
        }

        public Color DrawBackground()
        {
            return bg_color;
        }

        
        public void DrawTree(Graphics graphics, Point point)
        {
            throw new NotImplementedException();
        }

        
        public void DrawWaterSource(Graphics graphics, Point point)
        {
            Pen pen = new Pen(Color.Black);

            Circle circle = new Circle(graphics, pen, point, 30, 30, 0, 360);
            circle.Draw();

        }

        public void getName()
        {
            throw new NotImplementedException();
        }
    }
}
