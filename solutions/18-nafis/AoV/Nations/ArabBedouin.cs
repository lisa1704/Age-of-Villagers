using System;
using AoV.Shapes;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoV.Nations
{
    class ArabBedouin : INation
    {
        private Color bgColor = Color.Gold;

        public string getName()
        {
            return "Arabian Bedouin";
        }

        public Color TerrainColor()
        {
            return bgColor;
        }

        public void DrawHouse(Graphics g, Point p)
        {
            ArabHouse arabBeduinHouse = new ArabHouse(p);
            arabBeduinHouse.Draw(g);
           
        }

        public void DrawTree(Graphics g, Point p)
        {
            ArabTree aTree = new ArabTree(p);
            aTree.Draw(g);
        }

        public void DrawWaterSource(Graphics g, Point p)
        {
            NullShape nothing = new NullShape();
            nothing.Draw(g);
        }
    }
}
