﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace age_of_villagers
{
    public partial class VillageWindow : Form
    {
        string item;
        string vilName;
        string nType;
        SaveVillage savepoints;

        List<Point> house_point { get; set; } = new List<Point>();
        List<Point> tree_point { get; set; } = new List<Point>();
        List<Point> water_point { get; set; } = new List<Point>();

        public void getPoints()
        {
            this.savepoints = new SaveVillage(vilName, house_point, tree_point, water_point);
        }

        public void setPoints(SaveVillage vil)
        {
            village.Text = vil.village;
            foreach (Point pt in vil.house_point)
            {
                house_point.Add(pt);
            }
            foreach (Point pt in vil.tree_point)
            {
               tree_point.Add(pt);
            }
            foreach (Point pt in vil.water_point)
            {
                water_point.Add(pt);
            }
        }

        NationFactory n = new NationFactory();
        public VillageWindow()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e){}

        private void Panel1(object sender, PaintEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            
            foreach(Point pt in house_point)
            {
                n.CreateNation(nType).draw_house(g,pt);
            }

            foreach (Point pt in tree_point)
            {
                n.CreateNation(nType).draw_tree(g, pt);
            }

            foreach (Point pt in water_point)
            {
                n.CreateNation(nType).draw_watersource(g, pt);
            }
        }

        private void drawOnClick(object sender, MouseEventArgs e)
        {
            if(item=="house")
            {
                house_point.Add(e.Location);
            }
            else if(item=="tree")
            {
                tree_point.Add(e.Location);
            }
            else if(item=="water")
            {
                water_point.Add(e.Location);
            }
            panel1.Invalidate();
        }

        private void AgeOfVillagers_Click(object sender, EventArgs e){}

        private void VillageName_Click(object sender, EventArgs e){}

        private void villageName (object sender, EventArgs e)
        {
            vilName = village.Text;
        }

        private void Nation_Click(object sender, EventArgs e) { }

        private void nationType(object sender, EventArgs e)
        {
            nType = nations.Text;
            panel1.BackColor = n.CreateNation(nType).BackColor();
            panel1.Refresh();
        }

        private void tree_Click(object sender, EventArgs e)
        {
            item = "tree";
        }

        private void House_Click(object sender, EventArgs e)
        {
            item = "house";
        }

        private void WaterSource_Click(object sender, EventArgs e)
        {
            item = "water";
        }

        private void SaveVillage_Click(object sender, EventArgs e)
        {
            /*SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(File.Create(save.FileName));
                write.Write(village.Text);
                write.Dispose();
            }*/
            getPoints();
            Save save = new Save(savepoints);
            save.execute();
        }

        private void NewVillage_Click(object sender, EventArgs e)
        {
            house_point.Clear();
            tree_point.Clear();
            water_point.Clear();
            panel1.Refresh();
        }

        private void OpenVillage_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader read = new StreamReader(File.OpenRead(open.FileName));

                village.Text = read.ReadToEnd();
                read.Dispose();
            }*/
            if (nations.Text != "")
            {
                Openvillage open = new Openvillage();
                open.execute();
                savepoints = open.get_village();
                setPoints(savepoints);
                panel1.Refresh();
            }
            else
            {
                MessageBox.Show("VillgeType is not selected");
            }
        }
    }
}
