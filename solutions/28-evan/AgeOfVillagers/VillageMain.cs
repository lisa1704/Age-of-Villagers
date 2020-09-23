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
    public partial class VillageMain : Form
    {
        Color getColor;
        string nation;
        string nameOfVillage;
        string TypeOfVillage;
        public ConcreteNation newVillage = new ConcreteNation();
        ConcreteNation TypeOfNation = new ConcreteNation();

        public VillageMain()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            nation = comboBox1.Text;
            getColor = TypeOfNation.checkNation(nation).DrawTerrain();
            panel1.Refresh();
            panel1.BackColor = getColor;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
        }

        private void house_radio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void open_btn_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;

            Graphics g = panel1.CreateGraphics();

            Point p = new Point();

            p = e.Location;


            if (house.Checked == true)
            {
                TypeOfNation.checkNation(nation).DrawHouse(g, p);
            }

            else if (water_source.Checked == true)
            {
                TypeOfNation.checkNation(nation).DrawWaterSource(g, p);
            }

            else
                TypeOfNation.checkNation(nation).DrawTree(g, p);
        }
    }
}