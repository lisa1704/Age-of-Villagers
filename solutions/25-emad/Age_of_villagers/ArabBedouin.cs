using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_villagers
{
    class ArabBedouin : INations
    {

        Color bg_color = Color.LightYellow;
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
            throw new NotImplementedException();
        }

        public void getName()
        {
            throw new NotImplementedException();
        }
    }
}
