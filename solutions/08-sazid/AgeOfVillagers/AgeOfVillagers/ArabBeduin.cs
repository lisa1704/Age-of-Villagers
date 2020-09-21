using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class ArabBeduin : INation
    {
        private Color backGroundColor = Color.Orange;
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
            NullVillageItem nI = new NullVillageItem();
            nI.draw(g);
        }

        public Color GetColor()
        {
            return backGroundColor;
        }

        public string getNationName()
        {
            return "Arab Beduin";
        }
    }
}
