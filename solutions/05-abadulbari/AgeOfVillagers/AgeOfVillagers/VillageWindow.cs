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
        public INation nation;
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
            if (treeRadioBtn.Checked)
            {
                g.DrawString(text, new Font("Arial", 12), new SolidBrush(ForeColor), e.X, e.Y);

            }
            else if (houseRadioBtn.Checked)
            {
                nation.getHouse(point).draw(g, p);
            }
            else if (waterRadioBtn.Checked)
            {
                g.DrawString(text, new Font("Arial", 12), new SolidBrush(ForeColor), e.X, e.Y);
            }
        }
    }
}
