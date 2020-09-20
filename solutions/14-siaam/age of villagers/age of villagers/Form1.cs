using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace age_of_villagers
{
    public partial class aov_editor : Form
    {
        Color colorofbackground;
        string nameofnation;
        NationFactory nationtype = new NationFactory();
        //Graphics g;
        public aov_editor()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void nation_SelectedIndexChanged(object sender, EventArgs e)
        {
            nameofnation = nation.Text;
            colorofbackground = nationtype.GetNation(nameofnation).BgColor();
            panel1.BackColor = colorofbackground;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //Graphics g = panel1.CreateGraphics();
        }
    }
}
