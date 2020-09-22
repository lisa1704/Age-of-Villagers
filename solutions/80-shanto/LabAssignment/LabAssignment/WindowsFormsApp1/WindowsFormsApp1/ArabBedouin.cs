﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class ArabBedouin : INation
    {

        private readonly Graphics g;
        Pen mypen = new Pen(Color.Black, 1);

        public ArabBedouin(Graphics g)
        {
            this.g = g;
        }
        public void DrawHouse(MouseEventArgs e)
        {

            ArabBedouinHouse abh = new ArabBedouinHouse(g);
            abh.Draw(e);
        }

        public void DrawTree(MouseEventArgs e)
        {
            ArabBedouinTree abt = new ArabBedouinTree(g);
            abt.Draw(e);

        }

        public void DrawWaterSource(MouseEventArgs e)
        {

        }
        public Color drawcolor()
        {
            return Color.YellowGreen;
        }
        

        public string NationName()
        {
            return "Arab Bedouin";
        }
    }
    interface ITerrain
    {
        void draw();
    }
    class ArabBedouinTerrain : ITerrain
    {
        public void draw()
        {
            
        }
    }
}