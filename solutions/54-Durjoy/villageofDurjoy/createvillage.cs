﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace villageofDurjoy
{
    public partial class createvillage : Form
    {
        int X, Y;
        string text = "";
        string name = "";
        public Graphics g;
        public Pen p;
        public createvillage()
        {
            InitializeComponent();
           
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Housebutton_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void treeButton_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void Watersourcebutton_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void Newbutton_Click(object sender, EventArgs e)
        {

        }

        private void openbutton_Click(object sender, EventArgs e)
        {

        }
        private void savebutton_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void drawHouse(int X, int Y)
        {

            g.DrawLine(p, X - 25, Y + 35, X + 25, Y - 25);
            g.DrawLine(p, X + 25, Y - 25, X + 50, Y + 50);
            g.DrawLine(p, X + 50, Y + 50, X - 25, Y + 35);
            g.DrawLine(p, X + 25, Y - 25, X + 75, Y + 25);
            g.DrawLine(p, X + 75, Y + 25, X + 50, Y + 50);
        }





    }
}

