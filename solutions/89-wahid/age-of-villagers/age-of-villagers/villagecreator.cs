using age_of_villagers.nation;
using age_of_villagers.villageitem;
using age_of_villagers.shape;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace age_of_villagers
{
    public partial class villagecreator : Form
    {
        int x , y;
        string text = "";
        string name = "";
        public Graphics g;
        public Pen p;
        public Village village;
        List<Point> HousePoints = new List<Point>();
        List<Point> TreePoints = new List<Point>();
        List<Point> WaterPoints = new List<Point>();
        public villagecreator()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            p = new Pen(Color.Black);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ageofvillagers_Click(object sender, EventArgs e)
        {

        }

        private void villagenamebox_TextChanged(object sender, EventArgs e)
        {
            name = villagenamebox.Text;
        }

        private void villagename_Click(object sender, EventArgs e)
        {

        }

        private void villagelocationbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void villagelocation_Click(object sender, EventArgs e)
        {

        }

        private void tree_CheckedChanged(object sender, EventArgs e)
        {
            text = "tree";
        }

        private void house_CheckedChanged(object sender, EventArgs e)
        {
            text = "house";
        }

        private void watersource_CheckedChanged(object sender, EventArgs e)
        {
            text = "water";
        }

        private void savevillage_Click(object sender, EventArgs e)
        {

        }

        private void newvillage_Click(object sender, EventArgs e)
        {

        }

        private void openvillage_Click(object sender, EventArgs e)
        {

        }

        private void panel1MouseClick(object sender, MouseEventArgs e)
        {
            Point point = new Point(e.X, e.Y);

            switch (village)
            {
                case null:
                    {
                        DialogResult _dialog = MessageBox.Show("Open a Village First!");
                        break;
                    }

                default:
                    if (tree.Checked)
                    {

                        village.nation.getTree(point).draw(g, p);
                        village.tree.Add(point);
                    }
                    else if (house.Checked)
                    {
                        village.nation.getHouse(point).draw(g, p);
                        village.house.Add(point);

                    }
                    else if (watersource.Checked)
                    {
                        village.nation.getHouse(point).draw(g, p);
                        village.watersource.Add(point);
                    }

                    break;
            }
        }
    }
}
