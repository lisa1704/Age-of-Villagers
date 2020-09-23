﻿using AgeOfVillagers.Nations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeOfVillagers
{
   
    public partial class Form1 : Form
    {

        Point point;
        String nationName = " ";
        INation nation = new NullNation();
        INation nation2 = new NullNation();
        CheckNation checker = new CheckNation();

        public List<Point> house { get; set; } = new List<Point>();
        public List<Point> Tree { get; set; } = new List<Point>();
        public List<Point> water { get; set; } = new List<Point>();

        public Form1()
        {
            InitializeComponent();
        }
        private void NationName_TextChanged(object sender, EventArgs e)
        {
            nationName = Text;
        }

        private void canvas_MouseClick(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
            canvas.Invalidate();

        }
 private void NationChoose_SelectedIndexChanged(object sender, EventArgs e)
           {
            nation = checker.GetNation(NationChoose.Text);
            canvas.BackColor = nation.TerrainColor();
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = canvas.CreateGraphics();
            // BangladeshiFarmers nation = new BangladeshiFarmers();
            //  EgyptianKings nation = new EgyptianKings();
            //ArabBeouins nation = new ArabBeouins();
            //InuitHunters nation = new InuitHunters();
            
            canvas.BackColor = nation.TerrainColor();

            if (tree.Checked == true)
            {
                nation.DrawTree(g, point);
                Tree.Add(point);
            }
            else if (House.Checked == true)
            {
                nation.DrawHouse(g, point);
                house.Add(point);
            }
            else if (Water.Checked == true)
            {
                nation.DrawWater(g, point);
                water.Add(point);
            }

        }
        private void newVillage_MouseClick(object sender, MouseEventArgs e)
        {
            canvas.Invalidate();
        }

        private void NationChoose_DropDown(object sender, EventArgs e)
        {
            NationChoose.Items.Add("Bangladeshi Farmers");
            NationChoose.Items.Add("Arab Bedouin");
            NationChoose.Items.Add("Egyptian Kings");
            NationChoose.Items.Add("Inuit Hunters");
        }

        private void newVillage_Click(object sender, EventArgs e)
        {
            nation = nation2;
            tree.Checked = false ;
            House.Checked = false;
            Water.Checked = false;

        }
    }
}
