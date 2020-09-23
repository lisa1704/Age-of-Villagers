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
        Graphics g;
        List<Point> Locations = new List<Point>();

        public aov_editor()
        {
            InitializeComponent();
        }

      


        private void nation_SelectedIndexChanged(object sender, EventArgs e)
        {
            nameofnation = nation.Text;
            colorofbackground = nationtype.GetNation(nameofnation).BgColor();
            panel1.BackColor = colorofbackground;
        }

       

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            foreach (Point points in Locations)
            {
                nationtype.GetNation(nameofnation).drawTree(g, points);
            }

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Locations.Add(e.Location);
        }

        private void treebutton_Click(object sender, EventArgs e)
        {

        }

        private void vill_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void housebutton_Click(object sender, EventArgs e)
        {

        }

        private void waterbutton_Click(object sender, EventArgs e)
        {

        }

        private void open_vill_Click(object sender, EventArgs e)
        {

        }

        private void save_vill_Click(object sender, EventArgs e)
        {

        }

        private void new_vill_Click(object sender, EventArgs e)
        {
            Locations.Clear();
            panel1.Refresh();
            panel1.BackColor = Color.Transparent;
            nation.ResetText();
            vill_name.ResetText();
        }
    }
}
