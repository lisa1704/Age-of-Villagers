using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgeOfVillagers.Shapes;
using AgeOfVillagers.Items;

namespace AgeOfVillagers
{
    public class ArabBedouin : INation
    {
         public ArabBedouin()
        {

        }

        public string DrawHouse(Graphics g, Point point)
        {

            ArabHouse house = new ArabHouse();
            house.Draw(g, point);

            return "Bedouin House";
        }

        public string DrawTree(Graphics g, Point point)
        {
            ArabTree tree = new ArabTree();
            tree.Draw(g, point);

            return "Bedouin Tree";
        }
        public string DrawWaterSource(Graphics g, Point point)
        {
            MessageBox.Show("Bedouin villages do not build their own water source");
            return "Bedouin villages do not build their own water source";
        }
        public Color DrawTerrain()
        {
            return Color.LightGoldenrodYellow;
        }
    }
}
