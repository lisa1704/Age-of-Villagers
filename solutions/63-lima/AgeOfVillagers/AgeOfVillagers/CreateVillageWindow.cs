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
            VillageName myvillage = new VillageName();
            myvillage.Name = village_name.Text;
        }

        private void CreateVillageWindow_Load(object sender, EventArgs e)
        {

        }


        private void drawing_panel_MouseClick(object sender, MouseEventArgs e)
        {
            g = drawing_panel.CreateGraphics();
            //if (select_nation.Text == "Egyptian Kings")
            //{
            //    EgyptianKings egyptianKings = new EgyptianKings(drawing_panel);
            //    egyptianKings.paintTerrain();
            //    if (tree.Checked == true)
            //    {
            //        egyptianKings.drawTree(g, e.X, e.Y);
            //    }
            //    else if (house.Checked == true)
            //    {
            //        egyptianKings.drawHouse(g, e.X, e.Y);
            //    }
            //    else
            //    {
            //        egyptianKings.drawWaterSource(g, e.X, e.Y);
            //    }

            //}
            ////EgyptianKings egyptianKings = new EgyptianKings(drawing_panel);
            ////egyptianKings.paintTerrain();
            ////if (tree.Checked == true)
            ////{
            ////    egyptianKings.drawTree(g , e.X, e.Y);
            ////}
            ////else if(house.Checked == true)
            ////{
            ////    egyptianKings.drawHouse(g, e.X, e.Y);
            ////}
            ////else
            ////{
            ////    egyptianKings.drawWaterSource(g, e.X, e.Y);
            ////}

            //else if(select_nation.Text == "Bangladeshi Farmers") 
            //{
            //    BangladeshiFarmers bangladeshiFarmers = new BangladeshiFarmers(drawing_panel);
            //    bangladeshiFarmers.paintTerrain();
            //    if (tree.Checked == true)
            //    {
            //        bangladeshiFarmers.drawTree(g, e.X, e.Y);
            //    }
            //    else if (house.Checked == true)
            //    {
            //        bangladeshiFarmers.drawHouse(g, e.X, e.Y);
            //    }
            //    else
            //    {
            //        bangladeshiFarmers.drawWaterSource(g, e.X, e.Y);
            //    }
            //}
            ////BangladeshiFarmers bangladeshiFarmers = new BangladeshiFarmers(drawing_panel);
            ////bangladeshiFarmers.paintTerrain();
            ////if (tree.Checked == true)
            ////{
            ////    bangladeshiFarmers.drawTree(g, e.X, e.Y);
            ////}
            ////else if (house.Checked == true)
            ////{
            ////    bangladeshiFarmers.drawHouse(g, e.X, e.Y);
            ////}
            ////else
            ////{
            ////    bangladeshiFarmers.drawWaterSource(g, e.X, e.Y);
            ////}



        }

        private void tree_CheckedChanged(object sender, EventArgs e)
        {
            //text = "Tree";
        }

        private void house_CheckedChanged(object sender, EventArgs e)
        {
            //text = "House";
        }

        private void water_resource_CheckedChanged(object sender, EventArgs e)
        {
            //text = "Water Resource";
        }

        private void select_nation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
