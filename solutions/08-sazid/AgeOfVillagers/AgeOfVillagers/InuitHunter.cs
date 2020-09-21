using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    public class InuitHunter : INation
    {
        private Color backGroundColor = Color.White;
        public void DrawHouse(Graphics g, Point p)
        {
            InuitIgloo igloo = new InuitIgloo(p);
            igloo.draw(g);
        }

        public void DrawTree(Graphics g, Point p)
        {
            throw new NotImplementedException();
        }

        public void DrawWaterResource(Graphics g, Point p)
        {
            throw new NotImplementedException();
        }

        public Color GetColor()
        {
            return backGroundColor;
        }

        public string getNationName()
        {
            return "Inuit Hunter";
        }
    }
}
