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
        int x, y;
        Graphics g;
        string selected_nation = "";
        string selected_component = "";

        public VillageWindow()
        {
            InitializeComponent();
        }

        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = DrawingPanel.CreateGraphics();
            Pen p = new Pen(Color.Black);

        }

        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Lbl_aovtitle_Click(object sender, EventArgs e)
        {

        }

        private void Label_nation_Click(object sender, EventArgs e)
        {

        }

        private void Label_villName_Click(object sender, EventArgs e)
        {

        }

        private void btn_saveVillage_Click(object sender, EventArgs e)
        {
            SaveVillageForm svf = new SaveVillageForm();
            svf.Show();
        }

        private void btn_openVillage_Click(object sender, EventArgs e)
        {
            OpenVillageForm ovf = new OpenVillageForm();
            ovf.Show();
        }

        private void btn_newVillage_Click(object sender, EventArgs e)
        {

        }

        private void rbtn_house_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_house.Checked == true)
            {
                selected_component = "house";
            }
        }

        private void rbtn_tree_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_tree.Checked == true)
            {
                selected_component = "tree";
            }
        }

        private void rbtn_waterSource_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_waterSource.Checked == true)
            {
                selected_component = "water_source";
            }
        }

        private void nation_selector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(nation_selector.SelectedIndex == 0)
            {
                selected_nation = "arab";
            }
            if (nation_selector.SelectedIndex == 1)
            {
                selected_nation = "bd";
            }
            if (nation_selector.SelectedIndex == 2)
            {
                selected_nation = "egypt";
            }
            if (nation_selector.SelectedIndex == 3)
            {
                selected_nation = "inuit";
            }
        }

        private void DrawingPanel_MouseClick(object sender, MouseEventArgs e)
        {
            Point p = new Point(e.X, e.Y);
            x = p.X;
            y = p.Y;
            DrawingPanel.Invalidate();
        }
    }
}
