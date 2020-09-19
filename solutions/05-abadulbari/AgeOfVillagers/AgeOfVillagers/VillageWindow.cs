using AgeOfVillagers.Nation;
using AgeOfVillagers.Shapes;
using AgeOfVillagers.VillegeItems;
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
    public partial class VillageWindow : Form
    {
        int x, y;
        string text = "";
        public Graphics g;
        public Pen p;
        //public INation nation;
        public Village village;
        public VillageWindow()
        {
            InitializeComponent();
            g = drawingPanel.CreateGraphics();
            p = new Pen(Color.Black);
        }

        private void gameLabel_Click(object sender, EventArgs e)
        {

        }

        private void villageLabel_Click(object sender, EventArgs e)
        {

        }

        private void nationLabel_Click(object sender, EventArgs e)
        {

        }

        private void waterRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            text = "water";
        }

        private void openButton_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            Form f = new CreateNewVillageWindow(this);
            f.Show();
        }
     
        private void houseRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            text = "house";
        }

        private void treeRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            text = "tree";
        }

        private void drawingPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void drawingPanel_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = new Point(e.X, e.Y);
            VillageItem item;
            if (treeRadioBtn.Checked)
            {
                item = village.nation.getTree(point);
                village.trees.Add(item);
            }
            else if (houseRadioBtn.Checked)
            {
                item = village.nation.getHouse(point);
                village.houses.Add(item);
            }
            else
            {
                item = village.nation.getWaterSource(point);
                village.waterSources.Add(item);
            }
            item.draw(g, p);
        }
    }
}
