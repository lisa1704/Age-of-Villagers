﻿using System;
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
    public partial class CreateNewVillage : Form
    {
        string ItemNames = "";
        string village_name = "";
        string village_type = "";
        List<Point> tree_point = new List<Point>();
        List<Point> house_point = new List<Point>();
        List<Point> waterSource_point = new List<Point>();

        Factory_Nation nationfactory = new Factory_Nation();

        Items myItems;
        public CreateNewVillage()
        {
            InitializeComponent();
        }

        public void villageSaveState() //getting the info from form design
        {
            myItems.VillageName = VillageNametextBox.Text;
            myItems.Tree = this.tree_point;
            myItems.House = this.house_point;
            myItems.WaterSource = this.waterSource_point;
        }

        private void CreateNewVillage_Load(object sender, EventArgs e)
        {

        }

        private void AgeOfVillagers_Click(object sender, EventArgs e)
        {

        }

        private void villageName_Click(object sender, EventArgs e)
        {

        }

        private void nation_Click(object sender, EventArgs e)
        {

        }

        private void treeButton_CheckedChanged(object sender, EventArgs e)
        {
            ItemNames = "Tree";
        }

        private void houseButton_CheckedChanged(object sender, EventArgs e)
        {
            ItemNames = "House";
        }

        private void waterSourceButton_CheckedChanged(object sender, EventArgs e)
        {
            ItemNames = "WaterSource";
        }

        private void saveVillagebutton_Click(object sender, EventArgs e)
        {
            villageSaveState();
            VillageSaveOpen save_Village = new VillageSaveOpen(myItems);
            save_Village.saveMyVillage();
            MessageBox.Show(villageName.Text + "Village is saved");
        }

        private void newVillagebutton_Click(object sender, EventArgs e)
        {
            house_point.Clear();
            tree_point.Clear();
            waterSource_point.Clear();
            drawingPanel.Refresh();
            NationName.ResetText();
            MessageBox.Show("Panel is ready for new village to be created");
        }

        private void openVillagebutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Village is opened");
        }

        private void drawingPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = drawingPanel.CreateGraphics();

            foreach (Point point in tree_point)
            {
                nationfactory.GetNation(village_type).DrawTree(g, point);
            }

            foreach (Point point in house_point)
            {
                nationfactory.GetNation(village_type).DrawHouse(g, point);
            }

            foreach (Point point in waterSource_point)
            {
                nationfactory.GetNation(village_type).DrawWaterSource(g, point);
            }

        }

        private void drawingPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (ItemNames == "Tree")
            {
                tree_point.Add(e.Location);
            }

            if (ItemNames == "House")
            {
                house_point.Add(e.Location);
            }
         
            if (ItemNames == "WaterSource")
            {
                waterSource_point.Add(e.Location);
            }

            drawingPanel.Invalidate();
        }

        private void NationName_SelectedIndexChanged(object sender, EventArgs e)
        {
            village_type = NationName.Text;
            drawingPanel.BackColor = nationfactory.GetNation(village_type).BackgroundColor();
        }

        private void VillageNametextBox_TextChanged(object sender, EventArgs e)
        {
            village_name = VillageNametextBox.Text;
            villageName.Text = village_name;
        }
    }
}
