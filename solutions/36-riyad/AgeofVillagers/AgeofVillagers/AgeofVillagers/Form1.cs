using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeofVillagers
{
    public partial class Form1 : Form

    {
        int x;
        int y;
        string Text = "";
        string VName = "";
        Graphics g;
        string VType = "";
        Pen p;
        List<Point> HousePoints = new List<Point>();
        List<Point> TreePoints = new List<Point>();
        List<Point> WaterPoints = new List<Point>();

        FactoryPattern nationFactory = new FactoryPattern();

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void villageName_Click(object sender, EventArgs e)
        {

        }

        private void nation_Click(object sender, EventArgs e)
        {

        }

        private void tree_btn_Click(object sender, EventArgs e)
        {
            Text = "Tree";
        }

        private void house_btn_Click(object sender, EventArgs e)
        {
            Text = "House";
        }

        private void waterSource_btn_Click(object sender, EventArgs e)
        {
            Text = "Water";
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(VillageNameBox.Text + " Village saved");
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            DrawPanel.Dispose();
        }

        private void open_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Village opened");
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = DrawPanel.CreateGraphics();
            Pen p = new Pen(Color.Black);

            foreach (Point pt in HousePoints)
            {
                nationFactory.GetNation(VType).DrawHouse(g, pt);
            }
            foreach (Point pt in TreePoints)
            {
                nationFactory.GetNation(VType).DrawTree(g, pt);
            }
            foreach (Point pt in WaterPoints)
            {
                //g.DrawLine(p, pt.X, pt.Y, 100, 100);
            }
        }






        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NationList_Select(object sender, EventArgs e)
        {
            
        }

       /* private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            VType = nation.Text;
            DrawPanel.BackColor = nationFactory.GetNation(VType).TerrainColor();
        }*/

        private void VillageNameBox_TextChanged(object sender, EventArgs e)
        {
            VName = VillageNameBox.Text;
            //label2.Text = VName;
        }


        private void draw_panelMouseClick(object sender, MouseEventArgs e)
        {
            {

                if (Text == "House")
                {
                    HousePoints.Add(e.Location);
                }
                if (Text == "Tree")
                {
                    TreePoints.Add(e.Location);
                }
                if (Text == "WaterSource")
                {
                    WaterPoints.Add(e.Location);
                }
                DrawPanel.Invalidate();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            VType = nation.Text;
            DrawPanel.BackColor = nationFactory.GetNation(VType).TerrainColor();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
