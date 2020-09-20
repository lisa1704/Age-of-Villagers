using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    public class ArabBeduin : INation
    {
        private Color backGroundColor = Color.Orange;
        Pen pen = new Pen(Color.Black);
        public void DrawHouse(Graphics g, Point p)
        {
            ArabBeduinHouse arabBeduinHouse = new ArabBeduinHouse(p);
            arabBeduinHouse.draw(g);
        }

        public void DrawTree(Graphics g, Point p)
        {
            ArabBeduinTree aTree = new ArabBeduinTree(p);
            aTree.draw(g);
        }

        public void DrawWaterResource(Graphics g, Point p)
        {
            throw new NotImplementedException();
        }

        public Color GetColor()
        {
            return backGroundColor;
        }
    }
}
