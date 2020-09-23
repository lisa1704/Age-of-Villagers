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
        string itemType;
        List<Point> houses = new List<Point>();
        List<Point> trees = new List<Point>();

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
            foreach (Point points in houses)
            {
                nationtype.GetNation(nameofnation).drawHouse(g, points);
            }
           

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (itemType == "house")
            {
                houses.Add(e.Location);
            }
            
            panel1.Invalidate();
        }

        private void treebutton_Click(object sender, EventArgs e)
        {
            itemType = "tree";
        }

        private void vill_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void housebutton_Click(object sender, EventArgs e)
        {
            itemType = "house";
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
            houses.Clear();
            panel1.Refresh();
            panel1.BackColor = Color.Transparent;
            nation.ResetText();
            vill_name.ResetText();
        }
    }
}
