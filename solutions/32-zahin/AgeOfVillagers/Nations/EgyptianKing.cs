using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgeOfVillagers.Shapes;
using AgeOfVillagers.Items;
namespace AgeOfVillagers
{
    public class EgyptianKing : INation
    {
        Pen pen = new Pen(Color.Black);
        public EgyptianKing()
        {

        }

        public void DrawHouse(Graphics g, Point point)
        {
            EgyptHouse house = new EgyptHouse();
            house.Draw(g,point);
        }

        public void DrawTree(Graphics g, Point point)
        {
            EgyptTree tree = new EgyptTree();
            tree.Draw(g, point);
        }

        public void DrawWaterSource(Graphics g, Point point)
        {
            EgyptWater water = new EgyptWater();
            water.Draw(g, point);
        }
        public Color DrawTerrain()
        {
            return Color.Gold;
        }
    }
}
