using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_of_villagers
{
   
    public partial class VillageCreator : Form
    {
        int x, y;
        string text = "";
        string name = "";
        public Graphics g;
        public Pen p;


        public VillageCreator()
        {
            InitializeComponent();
            g = MainPanel.CreateGraphics();
            p = new Pen(Color.Black);
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void SaveVillage_Click(object sender, EventArgs e)
        {

        }


        private void OpenVillage_Click(object sender, EventArgs e)
        {

        }

        private void Tree_CheckedChanged(object sender, EventArgs e)
        {
            text = "tree";
        }

        private void House_CheckedChanged(object sender, EventArgs e)
        {
            text = "house";
        }

        private void WaterSource_CheckedChanged(object sender, EventArgs e)
        {
            text = "water";
        }

        private void NewVillage_Click(object sender, EventArgs e)
        {

        }


        private void NAtionName_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VillageNameBox_TextChanged(object sender, EventArgs e)
        {
            name = VillageNameBox.Text;
        }

        private void NationList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void main_panelMouseClick(object sender, MouseEventArgs e)
        {
            Point point = new Point(e.X, e.Y);
            Graphics g = MainPanel.CreateGraphics();
            g.DrawString(text, new Font("Arial", 12), new SolidBrush(ForeColor), e.X, e.Y);
            if (Tree.Checked)
            {

            }
            else if (House.Checked)
            {

            }
            else if (WaterSource.Checked)
            {

            }

        }


    }
}
