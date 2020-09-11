using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using AgeOfVillagers.Nations;

namespace AgeOfVillagers
{
    public class Egyptian : Nation
    {
        public override void BackgoundColor(Graphics g)
        {
            g.Clear(Color.Yellow);
            Debug.WriteLine("Yellow");
        }

        public override void DrawHouse(Graphics g, Point location)
        {
            
        }

        public override void DrawTree(Graphics g, Point location)
        {
            
        }

        public override void DrawWaterResource(Graphics g, Point location)
        {
            
        }
    }
}
