using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public partial class CreateVillageWindow : Form
    {
        //int x;
        //int y;
        //Graphics g;
        //string text = " ";
        public CreateVillageWindow()
        {
            InitializeComponent();
        }

        private void save_village_Click(object sender, EventArgs e)
        {

        }

        private void new_village_Click(object sender, EventArgs e)
        {
            drawing_panel.Refresh();
        }

        private void open_village_Click(object sender, EventArgs e)
        {

        }

        private void village_name_TextChanged(object sender, EventArgs e)
        {
            VillageName myvillage = new VillageName();
            myvillage.Name = village_name.Text;
        }

        private void CreateVillageWindow_Load(object sender, EventArgs e)
        {

        }


        private void drawing_panel_MouseClick(object sender, MouseEventArgs e)
        {
            //x = e.X;
            //y = e.Y;
            //g = drawing_panel.CreateGraphics();
            //Font fy = new Font("Arial", 10, FontStyle.Bold);
            //Brush br = new SolidBrush(System.Drawing.Color.Red);
            //g.DrawString(text, fy, br, new PointF(x, y));
            EgyptianKings egyptianKings = new EgyptianKings(drawing_panel);
            if (tree.Checked == true)
            {
                egyptianKings.drawTree(g, e.X, e.Y);
            }

            
        }

        private void tree_CheckedChanged(object sender, EventArgs e)
        {
            text = "Tree";
        }

        private void house_CheckedChanged(object sender, EventArgs e)
        {
            text = "House";
        }

        private void water_resource_CheckedChanged(object sender, EventArgs e)
        {
            text = "Water Resource";
        }
    }

}
