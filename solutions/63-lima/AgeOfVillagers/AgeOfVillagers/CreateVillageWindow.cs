﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VisioForge.Shared.MediaFoundation.OPM;

namespace AgeOfVillagers
{
    public partial class CreateVillageWindow : Form
    {
        //int x;
        //int y;
        Graphics g;
        //string text = " ";
        public CreateVillageWindow()
        {
            InitializeComponent();
        }

        private void save_village_Click(object sender, EventArgs e)
        {

        }

        private void new_village_Click(object sender, EventArgs e)
        {
            drawing_panel.Refresh();
        }

        private void open_village_Click(object sender, EventArgs e)
        {

        }

        private void village_name_TextChanged(object sender, EventArgs e)
        {
            Village myvillage = new Village();
            myvillage.Name = village_name.Text;
        }

        private void CreateVillageWindow_Load(object sender, EventArgs e)
        {

        }
        private void tree_CheckedChanged(object sender, EventArgs e)
        {
            //text = "tree";
        }
        private void house_checkedchanged(object sender, EventArgs e)
        {
           //ext = "house";
        }

        private void water_resource_checkedchanged(object sender, EventArgs e)
        {
            //xt = "water resource";
        }

        private void select_nation_selectedindexchanged(object sender, EventArgs e)
        {

        }


        private void drawing_panel_MouseClick(object sender, MouseEventArgs e)
        {
            g = drawing_panel.CreateGraphics();
            if (select_nation.Text == "Egyptian Kings")
            {
                EgyptianKings egyptiankings = new EgyptianKings(drawing_panel);
                egyptiankings.paintTerrain();
                if (tree.Checked == true)
                {
                    egyptiankings.drawTree(g, e.X, e.Y);
                }
                else if (house.Checked == true)
                {
                    egyptiankings.drawHouse(g, e.X, e.Y);
                }
                else
                {
                    egyptiankings.drawWaterSource(g, e.X, e.Y);
                }
            }


            else if (select_nation.Text == "Bangladeshi Farmers")
            {
                BangladeshiFarmers bangladeshiFarmers = new BangladeshiFarmers(drawing_panel);
                bangladeshiFarmers.paintTerrain();
                if (tree.Checked == true)
                {
                    bangladeshiFarmers.drawTree(g, e.X, e.Y);
                }
                else if (house.Checked == true)
                {
                    bangladeshiFarmers.drawHouse(g, e.X, e.Y);
                }
                else
                {
                    bangladeshiFarmers.drawWaterSource(g, e.X, e.Y);
                }
            }

            else if (select_nation.Text == "Arab Bedouin")
            {
                ArabBedouin arabBedouin = new ArabBedouin(drawing_panel);
                arabBedouin.paintTerrain();
                if (tree.Checked == true)
                {
                    arabBedouin.drawTree(g, e.X, e.Y);
                }
                else if (house.Checked == true)
                {
                    arabBedouin.drawHouse(g, e.X, e.Y);
                }
                else
                {
                    arabBedouin.drawWaterSource(g, e.X, e.Y);
                }
            }
            else if (select_nation.Text == "Inuit Hunters")
            {
                InuitHunters InuitHunters = new InuitHunters(drawing_panel);
                InuitHunters.paintTerrain();
                if (house.Checked == true)
                {
                    InuitHunters.drawHouse(g, e.X, e.Y);
                }
                else if (tree.Checked == true)
                {
                    InuitHunters.drawTree(g, e.X, e.Y);
                }
                else
                {
                    InuitHunters.drawWaterSource(g, e.X, e.Y);
                }
            }

        }
    }
}
