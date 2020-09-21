using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    public class EgyptianKing : INation
    {
        private Color backGroundColor = Color.Yellow;
        public void DrawHouse(Graphics g, Point p)
        {
            EgyptianHouse egyptianHouse = new EgyptianHouse(p);
            egyptianHouse.draw(g);
        }

        public void DrawTree(Graphics g, Point p)
        {
            EgyptianTree eTree = new EgyptianTree(p);
            eTree.draw(g);
        }

        public void DrawWaterResource(Graphics g, Point p)
        {
            EgyptianWaterSource waterSource = new EgyptianWaterSource(p);
            waterSource.draw(g);
        }

        public Color GetColor()
        {
            return backGroundColor;
        }

        public string getNationName()
        {
            return "Egyptian King";
        }
    }
}
