using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using AgeOfVillagers.Data_Objects;
using AgeOfVillagers.House;
using AgeOfVillagers.Nations;
using AgeOfVillagers.Tree;
using AgeOfVillagers.WaterResource;

namespace AgeOfVillagers
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
            EgyptianHouse egyptianHouse = new EgyptianHouse();
            HouseContext houseContext = new HouseContext(egyptianHouse, g, location, houseSize);

            houseContext.HouseDrawing();

            Debug.WriteLine("Drawing Egyptian House");
        }

        public override void DrawTree(Graphics g, Point location)
        {
            EgyptianTree egyptianTree = new EgyptianTree();
            TreeContext treeContext = new TreeContext(egyptianTree, g, location, treeSize);

            treeContext.TreeDrawing();

            Debug.WriteLine("Drawing Egyptian Tree");
        }

        public override void DrawWaterResource(Graphics g, Point location)
        {
            EgyptianWaterSource egyptianWaterSource = new EgyptianWaterSource();
            WaterSourceContext waterSourceContext = new WaterSourceContext(egyptianWaterSource,g,location,waterSourceSize);

        }
    }
}
