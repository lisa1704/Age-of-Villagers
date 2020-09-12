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

        int x;
        int y;
        Graphics g;
        string name = "";
        string VType = "";
        string Itemtext = "";
        List<Point> h_points = new List<Point>();
        List<Point> t_points = new List<Point>();
        List<Point> w_points = new List<Point>();


        public VillageWindow()
        {
            InitializeComponent();
        }

        private void VillageWindow_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
      
        private void House_Click(object sender, EventArgs e)
        {
            Itemtext = "House";
        }

        private void Tree_Click(object sender, EventArgs e)
        {
            Itemtext = "Tree";
        }

        private void WaterSource_Click(object sender, EventArgs e)
        {
            Itemtext = "WaterSource";
        }


        private void SaveVillage_Click(object sender, EventArgs e)
        {
            MessageBox.Show(VillageNameBox.Text+"Village saved");
        }

        private void OpenVillage_Click(object sender, EventArgs e)
        {
          //  MessageBox.Show("Village is Saved");
        }

        private void NewVbutton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Village is Saved");
        }

        private void VillageNameBox_TextChanged(object sender, EventArgs e)
        {
            name = VillageNameBox.Text;
        }

        private void NationList_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void DrawPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = DrawPanel.CreateGraphics();
            Pen p = new Pen(Color.Black);

        }

        private void draw_panelMouseClick(object sender, MouseEventArgs e)
        {
           
        }
    }
}
