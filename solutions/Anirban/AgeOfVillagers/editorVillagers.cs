﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgeOfVillagers.Nations;
using AgeOfVillagers.Shapes;

namespace AgeOfVillagers
{
    public partial class editorVillagers : Form
    {
        Color GetColor;
        string villageName;
        string nation;
        string selected_item;

        Nation_factory nation_type = new Nation_factory();

        List<Point> houses = new List<Point>();
        List<Point> trees = new List<Point>();

        public editorVillagers()
        {
            InitializeComponent();
        }



        private void villageNameBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void setVillageName(string name)
        {
            villageNameBox.Text = name;
            villageName = name;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            nation = comboBox1.Text;
            GetColor = nation_type.Check_nation(nation).terrain_Color();
            panel1.BackColor = GetColor;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            foreach (Point points in houses)
            {
                nation_type.Check_nation(nation).Draw_House(g,points);
            }
            
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {

            Graphics g = panel1.CreateGraphics();
            Pen blackpen = new Pen(Color.Black);

            g.DrawLine(blackpen, e.X,e.Y,e.X+10,e.Y-10);

            if (house_rb.Checked)
            {
                houses.Add(e.Location);
                panel1.Refresh();
            }
            
        }



        public void radioButton_Click()
        {
            if (house_rb.Checked)
            {
                selected_item = house_rb.Text;
            }
            else if (tree_rb.Checked)
            {
                selected_item = tree_rb.Text;
            }
            else if (water_rb.Checked)
            {
                selected_item = water_rb.Text;
            }
            else
                selected_item = "";


        }


        private void house_rb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tree_rb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void water_rb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void New_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
        }

        private void open_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {

        }
    }
}
