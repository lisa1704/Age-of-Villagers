using System.Drawing;
using System.Windows.Forms;
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
            return "Arab House";
        }

        public string DrawTree(Graphics g, Point point)
        {
            ArabTree tree = new ArabTree();
            tree.Draw(g, point);
            return "Arab Tree";
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
