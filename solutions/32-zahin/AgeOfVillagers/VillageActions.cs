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
    public partial class VillageActions : Form
    {
        string item;
        string villageName;
        string villageType;
        public Village newVillage = new Village();
        public List<Point> house { get; set; } = new List<Point>();
        public List<Point> tree { get; set; } = new List<Point>();
        public List<Point> water { get; set; } = new List<Point>();
        public VillageState state = new VillageState();
        public VillageActions() { InitializeComponent(); }

        private void VillageActions_Load(object sender, EventArgs e){}

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void House_Click(object sender, EventArgs e)
        {
            item = "house";
        }

        private void tree_Click(object sender, EventArgs e)
        {
            item = "tree";
        }

        private void Water_Click(object sender, EventArgs e)
        {
            item = "water";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            state.setState(villageName, house, tree, water);
            SaveVillage saveVillage = new SaveVillage(state.getState());
            saveVillage.execute();
        }

        private void OpenVIllage_Click(object sender, EventArgs e)
        {
            OpenVillage openVillage = new OpenVillage(state);
            openVillage.execute();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) 
        { 
            villageType = VillageNation.Text;
            newVillage.GetVillage(villageType);
            panel1.Refresh();
        }
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {   
            Graphics g = panel1.CreateGraphics();
            if (item == "house") 
            {
                house.Add(e.Location);
                foreach(Point point in house)
                    newVillage.GetVillage(villageType).DrawHouse(g, point); 
            }
            else if (item == "tree") 
            {
                tree.Add(e.Location);
                foreach (Point point in tree) 
                    newVillage.GetVillage(villageType).DrawTree(g, point); 
            }
            else if (item == "water") 
            {
                water.Add(e.Location);
                foreach (Point point in water)
                    newVillage.GetVillage(villageType).DrawWaterSource(g, point); 
            }
            panel1.BackColor = newVillage.GetVillage(villageType).DrawTerrain();
        }

        private void NewVillage_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
            panel2.Refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {}

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            villageName = textBox1.Text;
        }
    }
}