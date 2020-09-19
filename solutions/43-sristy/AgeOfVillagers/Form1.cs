using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Age_of_villagers
{
    public partial class Form1 : Form
    {
        string type;
        string item;
        Nationfactory nationfactory = new Nationfactory();
        village village;
        private string name;

        private List<Point> W_points { get; set; } = new List<Point>();
        private List<Point> T_points { get; set; } = new List<Point>();
        private List<Point> H_points { get; set; } = new List<Point>();

        public void get_state()
        {
            this.village = new village(villagename.Text, H_points, T_points, W_points);
        }

        public void set_state(village village)
        {
            villagename.Text = village.name;
            foreach(Point pt in village.house_point)
            {
                H_points.Add(pt);
            }
            foreach(Point pt in village.tree_point)
            {
                T_points.Add(pt);
            }
            foreach(Point pt in village.waterresource_point)
            {
                W_points.Add(pt);
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void side_panel(object sender, PaintEventArgs e) { }
        private void house_Click(object sender, EventArgs e)
        {
            item = "house";
        }

        private void tree_Click(object sender, EventArgs e)
        {
            item = "tree";
        }

        private void watersource_Click(object sender, EventArgs e)
        {
            item = "water";
        }

        private void draw_panel(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Black);
            Graphics g = drawpanel.CreateGraphics();
                foreach (Point pt in H_points)
                {
                nationfactory.GetNation(type).Draw_house(pt).paint(p,g);
                }
                foreach (Point pt in T_points)
                {
                nationfactory.GetNation(type).Draw_tree(pt).paint(p,g);
                }
                foreach (Point pt in W_points)
                {
                nationfactory.GetNation(type).Draw_watersource(pt).paint(p,g);
            }
        }

        private void drawpanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (item == "house")
            {
                H_points.Add(e.Location);
            }
            if (item == "tree")
            {
                T_points.Add(e.Location);
            }
            if (item == "water")
            {
                W_points.Add(e.Location);
            }
            drawpanel.Invalidate();
        }

        private void villagename_KeyDown(object sender, KeyEventArgs e)
        {
            name=villagename.Text;
        }

        private void vallagetype_SelectedIndexChanged(object sender, EventArgs e)
        {
            type = villagetype.Text;
            drawpanel.BackColor=nationfactory.GetNation(type).get_backcolor();
            drawpanel.Refresh();
        }

        private void save_Click(object sender, EventArgs e)
        {
            get_state();
            Savevillage command = new Savevillage(village);            
            command.execute();
        }

        private void open_Click(object sender, EventArgs e)
        {           
            if (villagetype.Text != "")
            {
                Openvillage command = new Openvillage();
                newvillage_Click(sender, e);
                command.execute();
                village=command.get_village();
                set_state(village);
                drawpanel.Refresh();
            }
            else
            {
                MessageBox.Show("VillgeType is not selected");
            }
        }

        private void newvillage_Click(object sender, EventArgs e)
        {
            villagename.Clear();
            H_points.Clear();
            T_points.Clear();
            W_points.Clear();
            drawpanel.Refresh();
            
        }
    }
}

