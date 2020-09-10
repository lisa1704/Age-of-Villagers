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
        public VillageWindow()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void House(object sender, EventArgs e)
        {

        }

        private void Tree(object sender, EventArgs e)
        {

        }

        private void WaterSource(object sender, EventArgs e)
        {

        }

        private void Save_Village(object sender, EventArgs e)
        {

        }
        practice pr = new practice();
        private void New_Village(object sender, EventArgs e)
        {
           
            village_name.Text = "Okay";
            pr.setName(village_name);
            Graphics g = drawing_panel.CreateGraphics();
            Pen p = new Pen(Color.Black);
            g.DrawEllipse(p, 10, 10, 100, 100);

        }

        private void Open_village(object sender, EventArgs e)
        {
            pr.setPanel(drawing_panel);
            
        }

        private void VillageWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
