using System;
using AoV.Shapes;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoV.Nations
{
    class EgyptianKing : INation
    {
        private Color bgColor = Color.Yellow;

        public string getName()
        {
            return "Egyptian Kings";
        }

        public Color TerrainColor()
        {
            return bgColor;
        }
        public void DrawHouse(Graphics g, Point p)
        {
            EgyptianHouse egyHouse = new EgyptianHouse(p);
            egyHouse.Draw(g);
        }

        public void DrawTree(Graphics g, Point p)
        {
            EgyptianTree egyTree = new EgyptianTree(p);
            egyTree.Draw(g);
        }

        public void DrawWaterSource(Graphics g, Point p)
        {
            EgyptianWell waterSource = new EgyptianWell(p);
            waterSource.Draw(g);
        }
    }
}
