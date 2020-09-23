using System;
using System.Collections.Generic;
using Age_of_villagers.Nations;
using Age_of_villagers.Shapes;
using Age_of_villagers.Components;
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
        int X, Y;
        string text = "";
        string name = "";
        String VType = "";
        public Graphics g;
        public Pen p;

        List<Point> HousePoints = new List<Point>();
        List<Point> TreePoints = new List<Point>();
        List<Point> WaterPoints = new List<Point>();

        public Village village;
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

        private void drawHouse(int X,int Y)
        {

            g.DrawLine(p, X , Y , X - 10, Y + 20);
            g.DrawLine(p, X -10, Y + 20, X + 10, Y + 20);
            g.DrawLine(p, X , Y , X + 10, Y + 20);
            g.DrawLine(p, X - 10, Y + 20, X + 10, Y + 20);
            g.DrawLine(p, X - 10, Y + 20, X - 10, Y + 40);
            g.DrawLine(p, X - 10, Y + 40, X + 10, Y + 40);
            g.DrawLine(p, X + 10, Y + 40, X + 10, Y + 20);

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

        private void MainPanel_Click(object sender, EventArgs e)
        {

        }

        

        private void main_panelMouseClick(object sender, MouseEventArgs e)
        {
            int x = e.Location.X;
            int y = e.Location.Y;

            try
            {
                if (Tree.Checked)
                {
                    
                }
                
                else if (House.Checked)
                {
                    drawHouse(x, y);
                }
                else if(WaterSource.Checked)
                {
                    
                }
            }
            catch (Exception)
            {
                

            }


        }


    }
}
