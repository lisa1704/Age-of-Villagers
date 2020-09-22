using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
    public class Egyptian : Nation
    {
        public Egyptian()
        {
            this.hasTree = true;
            this.hasWaterSource = true;
            this.waterSourceSize = new ElementSize(12, 12);
        }
        public override void BackgoundColor(Graphics g)
        {
            g.Clear(Color.Yellow);
            Debug.WriteLine("Yellow");
        }

        public override void DrawHouse(Graphics g, Point location)
        {
            EgyptianHouse egyptianHouse = new EgyptianHouse(location, houseSize);
            egyptianHouse.Draw(g);
            Debug.WriteLine("Drawing Egyptian House");
        }

        public override void DrawTree(Graphics g, Point location)
        {
            EgyptianTree egyptianTree = new EgyptianTree(location, treeSize);

            egyptianTree.Draw(g);

            Debug.WriteLine("Drawing Egyptian Tree");
        }

        public override void DrawWaterResource(Graphics g, Point location)
        {
            EgyptianWaterSource egyptianWaterSource = new EgyptianWaterSource(location, waterSourceSize);
            egyptianWaterSource.Draw(g);

            Debug.WriteLine("Drawing Egyptian Water Source");
        }
    }
}
