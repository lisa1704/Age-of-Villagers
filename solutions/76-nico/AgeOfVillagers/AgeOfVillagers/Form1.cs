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
    public partial class Form1 : Form
    {
     
        string ItemText = "";
        string name = "";
        string Vtype = "";
        List<Point> HousePoints = new List<Point>();
        List<Point> TreePoints = new List<Point>();
        List<Point> WaterPoints = new List<Point>();

        Factory_Nation nationfactory = new Factory_Nation();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DrawPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = DrawPanel.CreateGraphics();
            Pen p = new Pen(Color.Black);

            foreach (Point pt in HousePoints)
            {
              //  g.DrawLine(p, pt.X, pt.Y, 100, 100);
                nationfactory.GetNation(Vtype).draw_house(g, pt);
            }
            foreach (Point pt in TreePoints)
            {
                g.DrawLine(p, pt.X, pt.Y, 100, 100);
            }
            foreach (Point pt in WaterPoints)
            {
                g.DrawLine(p, pt.X, pt.Y, 100, 100);
            }

        }

        private void WaterSource_Click(object sender, EventArgs e)
        {
            ItemText = "WaterSource";        }

        private void Save_Village_Click(object sender, EventArgs e)
        {

        }

        private void Open_Village_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void House_Click(object sender, EventArgs e)
        {
            ItemText = "House";
        }

        private void Tree_Click(object sender, EventArgs e)
        {
            ItemText = "Tree";
        }

        private void Nations_SelectedIndexChanged(object sender, EventArgs e)
        {
      

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void VillageName_Click(object sender, EventArgs e)
        {

        }

        private void Drawpanel(object sender, MouseEventArgs e)
        {
            if (ItemText == "House")
            {
                HousePoints.Add(e.Location);
            }
            if (ItemText == "Tree")
            {
                TreePoints.Add(e.Location);
            }
            if (ItemText == "WaterSource")
            {
                WaterPoints.Add(e.Location);
            }
            DrawPanel.Invalidate();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
