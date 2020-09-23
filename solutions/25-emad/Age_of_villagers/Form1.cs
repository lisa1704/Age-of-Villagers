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
    public partial class Form1 : Form
    {

        String nation_name;

        Color ak_color;


        Nation nation = new Nation();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Village_name_Click(object sender, EventArgs e)
        {

        }

        private void Nations_Click(object sender, EventArgs e)
        {

        }

        private void Tree_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void House_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Water_source_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {

        }

        private void New_Click(object sender, EventArgs e)
        {

        }

        private void Open_Click(object sender, EventArgs e)
        {

        }

        private void Panel_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;

            Graphics g = panel.CreateGraphics();

            Point p = new Point();

            p = e.Location;





            if (house.Checked == true)
            {
                nation.CheckVillage(nation_name).DrawHouse(g, p);
            }

            else if (water_source.Checked == true)
            {
                nation.CheckVillage(nation_name).DrawWaterSource(g, p);
            }

            else
                nation.CheckVillage(nation_name).DrawTree(g, p);



        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            nation_name = comboBox1.Text;

            nation.CheckVillage(nation_name);

            panel.Refresh();

            ak_color = nation.CheckVillage(nation_name).DrawBackground();


            panel.BackColor = ak_color;

        }

        private void Villagename_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
