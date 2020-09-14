using AgeOfVillagers.House;
using AgeOfVillagers.Nations;
using AgeOfVillagers.Tree;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class Bangladeshi : Nation
    {
        
        public override void BackgoundColor(Graphics g)
        {
            g.Clear(Color.PaleGreen);
            Debug.WriteLine("PaleGreen");
        }

        public override void DrawHouse(Graphics g, Point location)
        {
            BangladeshiHouse bangladeshiHouse = new BangladeshiHouse();
            HouseContext houseContext = new HouseContext(bangladeshiHouse, g, location, houseSize);

            houseContext.HouseDrawing();

            Debug.WriteLine("Drawing Bangladeshi House");
        }

        public override void DrawTree(Graphics g, Point location)
        {
            BangladeshiTree bangladeshiTree = new BangladeshiTree();
            TreeContext treeContext = new TreeContext(bangladeshiTree,g,location,treeSize);

            treeContext.TreeDrawing();

            Debug.WriteLine("Drawing Bangladeshi Tree");
        }

        public override void DrawWaterResource(Graphics g, Point location)
        {
            
        }
    }
}
