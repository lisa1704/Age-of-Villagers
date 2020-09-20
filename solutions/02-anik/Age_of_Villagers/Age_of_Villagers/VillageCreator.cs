using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_of_Villagers
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
            g = panel1.CreateGraphics();
            p = new Pen(Color.Black);
        }
        private void VillageCreator_Load(object sender, EventArgs e)
        {

        }

        private void NewVillage_Click(object sender, EventArgs e)
        {

        }

        private void OpenVillage_Click(object sender, EventArgs e)
        {

        }

        private void SaveVillage_Click(object sender, EventArgs e)
        {

        }

        private void Tree_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void House_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void WaterSource_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            
        }

        private void VillageName_Click(object sender, EventArgs e)
        {

        }
        private void main_panelMouseClick(object sender, MouseEventArgs e)
        {
            Point point = new Point(e.X, e.Y);
            Graphics g = panel1.CreateGraphics();
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
