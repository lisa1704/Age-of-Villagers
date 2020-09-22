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

        String village_name;

        Color ak_color;


        Village village = new Village();


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

            village.CheckVillage(village_name).DrawWaterSource(g,p);




        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            village_name = comboBox1.Text;

            village.CheckVillage(village_name);

            panel.Refresh();

            ak_color = village.CheckVillage(village_name).DrawBackground();


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
