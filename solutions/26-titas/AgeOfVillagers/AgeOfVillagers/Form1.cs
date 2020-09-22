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
        BdFarmers bdFarmers = new BdFarmers();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void villageName_Click(object sender, EventArgs e)
        {

        }

        private void nation_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonTree_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonHouse_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonWaterSource_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        private void buttonNew_Click(object sender, EventArgs e)
        {

        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {

        }

        private void mouseClick_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void mouseClick(object sender, MouseEventArgs e)
        {
            
            
            
        }

        private void mouse_click(object sender, MouseEventArgs e)
        {
            int x, y;
            x = e.X;
            y = e.Y;
            Graphics g = panel1.CreateGraphics();

            Pen p = new Pen(new SolidBrush(Color.Red), 2);
            if (radioButtonHouse.Checked)
            {
                bdFarmers.paint_house(e, g, p);
            }
            else if (radioButtonTree.Checked)
            {
                bdFarmers.paint_tree(e, g, p);
            }

        }
    }
}
